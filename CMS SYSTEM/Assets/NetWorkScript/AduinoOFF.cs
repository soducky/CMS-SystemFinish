using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Uduino;
using PjlinkClient;

public class AduinoOFF : MonoBehaviour
{

    void Start()
    {
        UduinoManager.Instance.OnDataReceived += DataReceived;
    }

    void DataReceived(string data, UduinoDevice board)
    {
        if(data=="1")
        {
            GameObject.FindGameObjectWithTag("Server").GetComponent<Client>().AllOff();
        }
    }
}


