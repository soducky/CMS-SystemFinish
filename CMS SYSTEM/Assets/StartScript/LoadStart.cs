using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadStart : MonoBehaviour
{
    void Start()
    {
        Application.runInBackground = true; // 백그라운드 설정

        DataManager.Instance.LoadGameData();        
    }

    void Update()
    {
        
    }
}
