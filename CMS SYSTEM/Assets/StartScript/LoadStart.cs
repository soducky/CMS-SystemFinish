using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LoadStart : MonoBehaviour
{
    public GameObject UduinoObj;
    void Start()
    {
        Application.runInBackground = true; // ��׶��� ����

        DataManager.Instance.LoadGameData(); // ����� ������ �ҷ�����

        UduinoObj.transform.GetChild(0).GetChild(1).transform.position = new Vector2(6000f, 0);
    }
}
