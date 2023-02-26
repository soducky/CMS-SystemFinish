using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class SelectToggles : MonoBehaviour
{
    Toggle Toggle_solo; // 각 토글들

    string slice; // 문자열 공간
    int tmp; // 제목의 숫자  

    private void Start()
    {
        TitleTransfer();
        Toggle_solo = GetComponent<Toggle>();
        Togglestart();
        LoadToggleData();
    }

    public void Togglestart()
    {
        Toggle_solo.onValueChanged.AddListener(OnToggleValueChanged);
    }

    public void OnToggleValueChanged(bool boolean)
    {

        if (boolean == true)
        {
            DataManager.Instance.data.s[tmp - 1] = true;
        }


        else if (boolean == false)
        {
            DataManager.Instance.data.s[tmp - 1] = false;
        }
    }

    public void LoadToggleData()
    {

        if (Toggle_solo.isOn == false && DataManager.Instance.data.s[tmp - 1] == false)
        {
            return;
        }

        else if (Toggle_solo.isOn == false && DataManager.Instance.data.s[tmp - 1] == true)
        {
            Toggle_solo.isOn = true;
        }

        else if (Toggle_solo.isOn == true && DataManager.Instance.data.s[tmp - 1] == false)
        {
            Toggle_solo.isOn = false;
        }

        else if (Toggle_solo.isOn == true && DataManager.Instance.data.s[tmp - 1] == true)
        {
            return;
        }
    }

    void TitleTransfer()
    {
       // if(this.gameObject.name = )
        slice = this.gameObject.name;
        String substring = slice.Substring(6);
        tmp = int.Parse(substring);
    }
}

