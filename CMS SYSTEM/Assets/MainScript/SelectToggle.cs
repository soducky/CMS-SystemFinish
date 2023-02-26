/*using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class SelectToggle : MonoBehaviour
{
    public GameObject cms_solo;
    Toggle Toggle_solo;

    string slice;
    int tmp;

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
            cms_solo.SetActive(true);

            DataManager.Instance.data.s[tmp - 1] = true;
        }


        else if (boolean == false)
        {
            cms_solo.SetActive(false);

            DataManager.Instance.data.s[tmp - 1] = false;
        }
    }

    public void LoadToggleData()
    {

        if (Toggle_solo.isOn == false && DataManager.Instance.data.s[tmp-1] == false)
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
      
    public void Save()
    {
       DataManager.Instance.SaveGameData();
    }

     void TitleTransfer()
    {
        slice = this.gameObject.name; 
        String substring = slice.Substring(6, 2); 
        tmp = int.Parse(substring);
    }
}
*/