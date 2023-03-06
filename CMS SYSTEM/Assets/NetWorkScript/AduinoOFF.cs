using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Uduino;

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
            GameObject.FindWithTag("Server").GetComponent<Server>().AllOffBtn();
        }
    }

}


