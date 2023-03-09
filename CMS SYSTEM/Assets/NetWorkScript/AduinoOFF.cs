using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Uduino;
using PjlinkClient;

public class AduinoOFF : MonoBehaviour
{
    int h;
    string _hostName;
    int _port;

    void Start()
    {
        UduinoManager.Instance.OnDataReceived += DataReceived;
    }

    void DataReceived(string data, UduinoDevice board)
    {
        if(data=="1")
        {
            for (h = 0; h < DataManager.Instance.data.i; h++)
            {
                if (DataManager.Instance.data.modeSelect[h] == true && DataManager.Instance.data.IPAddress[h] != "0")
                {
                    string mes = DataManager.Instance.data.IPAddress[h];
                    GameObject.FindWithTag("Server").GetComponent<Client>().OnSendButton(mes);
                }

                else if (DataManager.Instance.data.modeSelect[h] == false && DataManager.Instance.data.IPAddress[h] != "0")
                {
                    Invoke("AllOffBtnLaterPJ2", float.Parse(DataManager.Instance.data.Devel_Time));
                }
            }
        }
    }

    public void AllOffBtnLaterPJ2()
    {
        for (h = 0; h < DataManager.Instance.data.i; h++)
        {
            _hostName = DataManager.Instance.data.IPAddress[h];
            _port = int.Parse(DataManager.Instance.data.Port[h]);

            if (_port == 4352)
            {
                PjlinkClient2 PJ = new PjlinkClient2(_hostName, _port, 2000);
                PJ.PowerOff();

                if (PJ.value == 2)
                {
                    DataManager.Instance.data.ImageLight[h] = false;
                    DataManager.Instance.data.ZoneLight[h] = false;
                }
            }
        }
    }

}


