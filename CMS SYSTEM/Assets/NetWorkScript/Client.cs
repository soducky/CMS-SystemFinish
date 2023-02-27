using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Net.Sockets;
using System.IO;
using System;

public class Client : MonoBehaviour
{
    string clientName;

    bool socketReady;

    TcpClient socket;
    NetworkStream stream;
    StreamWriter writer;
    StreamReader reader;

    private void Start()
    {
        ConnectToServer();
    }
    public void ConnectToServer()
    {
        // 이미 연결되었다면 함수 무시
        if (socketReady) return;

        // 기본 호스트/ 포트번호
        string ip = DataManager.Instance.data.Devel_IP;
        int port = int.Parse(DataManager.Instance.data.Devel_Port);

        // 소켓 생성
        try
        {
            socket = new TcpClient(ip, port);
            stream = socket.GetStream();
            writer = new StreamWriter(stream);
            reader = new StreamReader(stream);
            socketReady = true;
        }
        catch (Exception e)
        {
            Debug.Log("소켓에러" + e);
        }
    }

    void Update()
    {
        if (socketReady && stream.DataAvailable)
        {
            string data = reader.ReadLine();
            if (data != null)
                OnIncomingData(data);
        }
    }

    void OnIncomingData(string data)
    {
        if (data == "%NAME")
        {
            clientName = DataManager.Instance.data.Devel_Name;
            Send($"&NAME|{clientName}");
            return;
        }

        Debug.Log(data);
    }

    void Send(string data)
    {
        if (!socketReady) return;

        writer.WriteLine(data);
        writer.Flush();
    }

    public void OnSendButton(string SendInput) // 문자를 계속 보내면서 서버가 열렸는지 확인 
    {
        if (SendInput.Trim() == "") return;
        string message = SendInput;

        Send(message);

    }
    void OnApplicationQuit()
    {
        CloseSocket();
    }

    void CloseSocket()
    {
        if (!socketReady) return;

        writer.Close();
        reader.Close();
        socket.Close();
        socketReady = false;
    }
}
