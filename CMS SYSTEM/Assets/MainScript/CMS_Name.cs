using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CMS_Name : MonoBehaviour
{
    public Text[] cms_text_name;

    void Start()
    {
        for (int i = 0; i < DataManager.Instance.data.i; i++)
        {
            cms_text_name[i].text = DataManager.Instance.data.Name[i];
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
