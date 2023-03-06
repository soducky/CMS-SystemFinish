using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadUduino : MonoBehaviour
{
    public GameObject UduinoObj;
    void Start()
    {
        UduinoObj.transform.GetChild(0).GetChild(1).transform.position = new Vector2(6000f, 0);
    }

}
