using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadStart : MonoBehaviour
{
    void Start()
    {
        Application.runInBackground = true; // ��׶��� ����

        DataManager.Instance.LoadGameData();        
    }

    void Update()
    {
        
    }
}
