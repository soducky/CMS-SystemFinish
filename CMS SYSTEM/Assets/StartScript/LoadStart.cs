using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LoadStart : MonoBehaviour
{
    public GameObject UduinoObj;
    void Start()
    {
        Application.runInBackground = true; // 백그라운드 설정

        DataManager.Instance.LoadGameData(); // 저장된 데이터 불러오기

        UduinoObj.transform.GetChild(0).GetChild(1).transform.position = new Vector2(6000f, 0);
    }
}
