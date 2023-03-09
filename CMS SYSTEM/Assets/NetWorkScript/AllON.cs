using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Sockets;
using System.Net;
using UnityEngine;
using System.Net.Mail;
using PjlinkClient;
using UnityEngine.UI;

public class AllON : MonoBehaviour
{

    public Image StateLightImg;
    public Sprite GreenLight;

    string _hostName;
    int _port;
    int h;

    void Update()
    {
        if (DataManager.Instance.data.ZoneLight[0] == true &&
       DataManager.Instance.data.ZoneLight[1] == true &&
       DataManager.Instance.data.ZoneLight[2] == true &&
       DataManager.Instance.data.ZoneLight[3] == true &&
       DataManager.Instance.data.ZoneLight[4] == true &&
       DataManager.Instance.data.ZoneLight[5] == true &&
       DataManager.Instance.data.ZoneLight[6] == true &&
       DataManager.Instance.data.ZoneLight[7] == true &&
       DataManager.Instance.data.ZoneLight[8] == true &&
       DataManager.Instance.data.ZoneLight[9] == true &&
       DataManager.Instance.data.ZoneLight[10] == true &&
       DataManager.Instance.data.ZoneLight[11] == true &&
       DataManager.Instance.data.ZoneLight[12] == true &&
       DataManager.Instance.data.ZoneLight[13] == true &&
       DataManager.Instance.data.ZoneLight[14] == true &&
       DataManager.Instance.data.ZoneLight[15] == true &&
       DataManager.Instance.data.ZoneLight[16] == true &&
       DataManager.Instance.data.ZoneLight[17] == true &&
       DataManager.Instance.data.ZoneLight[18] == true &&
       DataManager.Instance.data.ZoneLight[19] == true &&
       DataManager.Instance.data.ZoneLight[20] == true &&
       DataManager.Instance.data.ZoneLight[21] == true &&
       DataManager.Instance.data.ZoneLight[22] == true &&
       DataManager.Instance.data.ZoneLight[23] == true &&
       DataManager.Instance.data.ZoneLight[24] == true &&
       DataManager.Instance.data.ZoneLight[25] == true &&
       DataManager.Instance.data.ZoneLight[26] == true &&
       DataManager.Instance.data.ZoneLight[27] == true &&
       DataManager.Instance.data.ZoneLight[28] == true &&
       DataManager.Instance.data.ZoneLight[29] == true &&
       DataManager.Instance.data.ZoneLight[30] == true &&
       DataManager.Instance.data.ZoneLight[31] == true &&
       DataManager.Instance.data.ZoneLight[32] == true &&
       DataManager.Instance.data.ZoneLight[33] == true &&
       DataManager.Instance.data.ZoneLight[34] == true &&
       DataManager.Instance.data.ZoneLight[35] == true &&
       DataManager.Instance.data.ZoneLight[36] == true &&
       DataManager.Instance.data.ZoneLight[37] == true &&
       DataManager.Instance.data.ZoneLight[38] == true &&
       DataManager.Instance.data.ZoneLight[39] == true &&
       DataManager.Instance.data.ZoneLight[40] == true &&
       DataManager.Instance.data.ZoneLight[41] == true &&
       DataManager.Instance.data.ZoneLight[42] == true &&
       DataManager.Instance.data.ZoneLight[43] == true &&
       DataManager.Instance.data.ZoneLight[44] == true &&
       DataManager.Instance.data.ZoneLight[45] == true &&
       DataManager.Instance.data.ZoneLight[46] == true &&
       DataManager.Instance.data.ZoneLight[47] == true &&
       DataManager.Instance.data.ZoneLight[48] == true &&
       DataManager.Instance.data.ZoneLight[49] == true &&
       DataManager.Instance.data.ZoneLight[50] == true &&
       DataManager.Instance.data.ZoneLight[51] == true &&
       DataManager.Instance.data.ZoneLight[52] == true &&
       DataManager.Instance.data.ZoneLight[53] == true &&
       DataManager.Instance.data.ZoneLight[54] == true &&
       DataManager.Instance.data.ZoneLight[55] == true)
        {
            StateLightImg.sprite = GreenLight;
        }
    }

    public void AllOnBtnClik()
    {
        for(h=0; h<DataManager.Instance.data.i; h++)
        {
            if (DataManager.Instance.data.modeSelect[h] == false && DataManager.Instance.data.IPAddress[h] != "0")
            {
                _hostName = DataManager.Instance.data.IPAddress[h];
                _port = int.Parse(DataManager.Instance.data.Port[h]);

                if (_port == 4352)
                {
                    PjlinkClient2 PJ = new PjlinkClient2(_hostName, _port, 2000);
                    PJ.PowerOn();

                    if (PJ.value == 1)
                    {
                        DataManager.Instance.data.ImageLight[h] = true;
                        DataManager.Instance.data.ZoneLight[h] = true;
                    }
                }
            }

            else if (DataManager.Instance.data.modeSelect[h] == true && DataManager.Instance.data.IPAddress[h] != "0")
            {
                Invoke("MagicPacketAll", float.Parse(DataManager.Instance.data.Devel_Time));
            }
        }
    }

    public void MagicPacketAll()
    {
        for (h = 0; h < DataManager.Instance.data.i; h++)
        {
            if (DataManager.Instance.data.modeSelect[h] == true && DataManager.Instance.data.IPAddress[h] != "0")
            {
                UdpClient udpClient = new UdpClient();
                udpClient.EnableBroadcast = true;

                var dgram = new byte[1024];

                for (int i = 0; i < 6; i++)
                {
                    dgram[i] = 255;
                }

                byte[] address_bytes = new byte[6];

                for (int i = 0; i < 6; i++)
                {
                    address_bytes[i] = byte.Parse(DataManager.Instance.data.MacAddress[h].Substring(3 * i, 2), NumberStyles.HexNumber);
                }

                var macaddress_block = dgram.AsSpan(6, 16 * 6);

                for (int i = 0; i < 16; i++)
                {
                    address_bytes.CopyTo(macaddress_block.Slice(6 * i));
                }

                udpClient.Send(dgram, dgram.Length, new System.Net.IPEndPoint(IPAddress.Broadcast, int.Parse(DataManager.Instance.data.Port[h])));

                Debug.Log("m_port : " + DataManager.Instance.data.Port[h]);
                Debug.Log("macaddres : " + DataManager.Instance.data.MacAddress[h]);

                udpClient.Close();
            }
        }
    }
}
