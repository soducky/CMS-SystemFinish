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

public class Data // 씬 이동시 데이터 저장할 것들
{
    public int i = 1; // clone 오브젝트(정보 담고있는 오브젝트)의 갯수 

    public bool[] s = new bool[] {false, false, false, false, false, false, false,false, false, false,
        false, false, false, false, false, false, false, false, false, false,
        false, false, false, false, false, false, false, false, false, false,
        false, false, false, false, false, false, false, false, false, false,
        false, false, false, false, false, false, false, false, false, false,
        false, false, false, false, false, false}; // 숨기기모드 토글 

    public bool[] modeSelect = new bool[] {true, true, true, true, true, true, true, true, true, true,
         true, true, true, true, true, true, true, true, true, true,
         true, true, true, true, true, true, true,true,true, true,
         true,true,true,true,true,true,true,true,true,true,
         true,true,true,true,true,true,true,true,true,true,
         true,true,true,true,true,true}; // PC모드, PJ모드 선택 스위치 

    public bool[] ImageLight = new bool[] {false, false, false, false, false, false, false,false, false, false,
        false, false, false, false, false, false, false, false, false, false,
        false, false, false, false, false, false, false, false, false, false,
        false, false, false, false, false, false, false, false, false, false,
        false, false, false, false, false, false, false, false, false, false,
        false, false, false, false, false, false }; // 이미지 교체 스위치 

    public string Devel_Port; // 개발자모드 서버의 포트 입력
    public string Devel_IP; // 개발자모드 서버의 IP 입력
    public string Devel_Name; // 개발자모드 서버의 이름 입력

    public List<String> Name = new List<String>(); // 각각의 정보들 리스트로 담음
    public List<String> MacAddress = new List<String>();
    public List<String> IPAddress = new List<String>();
    public List<string> Port = new List<string>();
    public List<String> ZoneName = new List<String>();


    
}

