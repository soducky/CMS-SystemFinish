
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

public class Server : MonoBehaviour
{

    List<ServerClient> clients;
    List<ServerClient> disconnectList;

    TcpListener server;
    bool serverStarted;

    private void Start()
    {
        ServerCreate();

       // this.gameObject.GetComponent<Client>().ConnectToServer();
    }

    public void ServerCreate()
    {
        clients = new List<ServerClient>();
        disconnectList = new List<ServerClient>();

        try
        {
            int port = int.Parse(DataManager.Instance.data.Devel_Port);
            server = new TcpListener(IPAddress.Any, port);
            server.Start();

            StartListening();
            serverStarted = true;
            Debug.Log("�������� ��Ʈ��ȣ : " + port);
        }
        catch (Exception e)
        {
            Debug.Log("���Ͽ���" + e);
        }
    }

    void Update()
    {
        if (!serverStarted) return;

        foreach (ServerClient c in clients)
        {
            // Ŭ���̾�Ʈ�� ������ ����Ǿ� �ִ��� Ȯ��, ������ disconnectList�� �߰� 
            if (!IsConnected(c.tcp))
            {
                c.tcp.Close();
                disconnectList.Add(c);
                continue;
            }
            // ����Ǿ������� ������Ʈ���� ���鼭 Ŭ���̾�Ʈ�κ��� �޼����� �޴´�. 
            else
            {
                NetworkStream s = c.tcp.GetStream();
                if (s.DataAvailable)
                {
                    string data = new StreamReader(s, true).ReadLine();
                    if (data != null)
                        OnIncomingData(c, data);
                }
            }
        }

        for (int i = 0; i < disconnectList.Count - 1; i++)
        {
            Broadcast($"{disconnectList[i].clientName} ������ ���������ϴ�", clients); // �� �κ� ����

            clients.Remove(disconnectList[i]);
            disconnectList.RemoveAt(i);
        }
    }



    bool IsConnected(TcpClient c)
    {
        try
        {
            if (c != null && c.Client != null && c.Client.Connected)
            {
                if (c.Client.Poll(0, SelectMode.SelectRead))
                    return !(c.Client.Receive(new byte[1], SocketFlags.Peek) == 0); // Ŭ���̾�Ʈ�� ����Ǹ� �������� 1����Ʈ ������ ����

                return true;
            }
            else
                return false;
        }
        catch
        {
            return false;
        }
    }

    void StartListening()
    {
        server.BeginAcceptTcpClient(AcceptTcpClient, server);  //�񵿱�� ��� ��� 
    }

    void AcceptTcpClient(IAsyncResult ar)
    {
        TcpListener listener = (TcpListener)ar.AsyncState;
        clients.Add(new ServerClient(listener.EndAcceptTcpClient(ar)));
        StartListening();

 
        Broadcast("%NAME", new List<ServerClient>() { clients[clients.Count - 1] });
        // �񵿱�� ��� �����鼭 Ŭ���̾�Ʈ���� ���� �޽����� ��ε�ĳ��Ʈ�� ���ؼ� ����� ��ο��� ����
    }


    void OnIncomingData(ServerClient c, string data)
    {
        if (data.Contains("&NAME"))
        {
            c.clientName = data.Split('|')[1];
            Broadcast($"{c.clientName} ����Ǿ����ϴ�", clients); // ����ȰŸ� Ŭ���̾�Ʈ�鿡�� ������ 
            return;
        }

        Broadcast($"{c.clientName} : {data}", clients);
    }

    void Broadcast(string data, List<ServerClient> cl)
    {
        foreach (var c in cl)
        {
            try
            {
                StreamWriter writer = new StreamWriter(c.tcp.GetStream());
                writer.WriteLine(data);
                writer.Flush();
            }
            catch (Exception e)
            {
                Debug.Log("���� ����" + e);
            }
        }
    }
}


public class ServerClient
{
    public TcpClient tcp;
    public string clientName;

    public ServerClient(TcpClient clientSocket)
    {
        clientName = "Guest";
        tcp = clientSocket;
    }
}