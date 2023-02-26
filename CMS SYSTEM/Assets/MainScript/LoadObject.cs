using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class LoadObject : MonoBehaviour
{
    public GameObject[] CMSList;
    //public Toggle[] togglestext;

    private void Awake()
    {
        Application.runInBackground = true;
    }

    void Start()
    {
        DataManager.Instance.LoadGameData();

        for (int i = 0; i < 56; i++)
        {
            if (DataManager.Instance.data.s[i] == false)
            {
                CMSList[i].gameObject.SetActive(false);
            }
        }
/*
        for (int i = 0; i < 56; i++)
        {
            if (DataManager.Instance.data.modeSelect[i] == false)
            {
                togglestext[i].isOn= false;
                togglestext[i].transform.GetChild(2).GetComponent<Text>().text = "PJ Mode";
            }
        }*/
    }

    void Update()
    {

    }
}
