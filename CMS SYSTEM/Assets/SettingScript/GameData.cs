using System;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using Toggle = UnityEngine.UI.Toggle;

[Serializable] // 직렬화

public class Data
{
    public int i = 1;

    public bool[] s = new bool[] {true, true, true, true, true, true, true, true, true, true,
         true, true, true, true, true, true, true, true, true, true,
         true, true, true, true, true, true, true,true,true, true,
         true,true,true,true,true,true,true,true,true,true,
         true,true,true,true,true,true,true,true,true,true,
         true,true,true,true,true,true};

    public bool[] modeSelect = new bool[] {true, true, true, true, true, true, true, true, true, true,
         true, true, true, true, true, true, true, true, true, true,
         true, true, true, true, true, true, true,true,true, true,
         true,true,true,true,true,true,true,true,true,true,
         true,true,true,true,true,true,true,true,true,true,
         true,true,true,true,true,true};

    public bool[] ImageLight = new bool[] {false, false, false, false, false, false, false,false, false, false,
        false, false, false, false, false, false, false, false, false, false,
        false, false, false, false, false, false, false, false, false, false,
        false, false, false, false, false, false, false, false, false, false,
        false, false, false, false, false, false, false, false, false, false,
        false, false, false, false, false, false };

    public string Devel_Port;
    public string Devel_IP;
    public string Devel_Name;

    public List<String> Name = new List<String>();
    public List<String> MacAddress = new List<String>();
    public List<String> IPAddress = new List<String>();
    public List<string> Port = new List<string>();
    public List<String> ZoneName = new List<String>();

    public GameObject ServerObject;
    
}

