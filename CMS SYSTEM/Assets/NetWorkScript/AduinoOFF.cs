using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;


public class AduinoOFF : MonoBehaviour
{
    SerialPort arduino = new SerialPort("COM3", 9600);

    // Start is called before the first frame update
    void Start()
    {
        arduino.Open();
     //   arduino.ReadTimeout = 5000;
    }

    // Update is called once per frame
    void Update()
    {
        if (arduino.IsOpen)
        {
            try
            {
                CmsOffControl(arduino.ReadByte());
            }

            catch(System.Exception) 
            {
                throw;
            }

        }

    }

    void CmsOffControl(int Num)
    {
        Debug.Log(Num);
    }
}


