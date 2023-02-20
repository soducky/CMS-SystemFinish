using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Cache;
using UnityEngine;
using UnityEngine.UI;

public class InputData : MonoBehaviour
{

    public void WarmingUpLoad()
    {
        List<GameObject> clonelist = GameObject.FindWithTag("AddButton").GetComponent<AddButton>().clonelist;

        for (int k = 0; k < DataManager.Instance.data.i; k++)
        {
            clonelist[k].transform.GetChild(2).GetComponent<InputField>().text = PlayerPrefs.GetString("Name" + k.ToString());
            clonelist[k].transform.GetChild(1).GetComponent<InputField>().text = PlayerPrefs.GetString("MacAddress" + k.ToString());
            clonelist[k].transform.GetChild(0).GetComponent<InputField>().text = PlayerPrefs.GetString("IPAddress" + k.ToString());
            clonelist[k].transform.GetChild(3).GetComponent<InputField>().text = PlayerPrefs.GetInt("Port" + k.ToString()).ToString();
            clonelist[k].transform.GetChild(7).GetComponent<InputField>().text = PlayerPrefs.GetString("ZoneName" + k.ToString());
        }
    }

    public void WarmingUpSave()
    {
        PlayerPrefs.DeleteAll();

        List<GameObject> clonelist = GameObject.FindWithTag("AddButton").GetComponent<AddButton>().clonelist;

        for (int k = 0; k < DataManager.Instance.data.i; k++)
        {
 
            PlayerPrefs.SetString("Name" + k.ToString(), clonelist[k].transform.GetChild(2).GetComponent<InputField>().text);
            PlayerPrefs.SetString("MacAddress" + k.ToString(), clonelist[k].transform.GetChild(1).GetComponent<InputField>().text);
            PlayerPrefs.SetString("IPAddress" + k.ToString(), clonelist[k].transform.GetChild(0).GetComponent<InputField>().text);
            PlayerPrefs.SetInt("Port" + k.ToString(), Int32.Parse(clonelist[k].transform.GetChild(3).GetComponent<InputField>().text));
            PlayerPrefs.SetString("ZoneName" + k.ToString(), clonelist[k].transform.GetChild(7).GetComponent<InputField>().text);
        }
    }

    public void GameDataSaveKey() 
    {
        DataManager.Instance.data.Name.Clear();
        DataManager.Instance.data.MacAddress.Clear();
        DataManager.Instance.data.IPAddress.Clear();
        DataManager.Instance.data.Port.Clear();
        DataManager.Instance.data.ZoneName.Clear();

        for (int k = 0; k < DataManager.Instance.data.i; k++)
        {
            DataManager.Instance.data.Name.Add(PlayerPrefs.GetString("Name" + k.ToString()));
            DataManager.Instance.data.MacAddress.Add(PlayerPrefs.GetString("MacAddress" + k.ToString()));
            DataManager.Instance.data.IPAddress.Add(PlayerPrefs.GetString("IPAddress" + k.ToString()));
            DataManager.Instance.data.Port.Add(PlayerPrefs.GetInt("Port" + k.ToString()).ToString());
            DataManager.Instance.data.ZoneName.Add(PlayerPrefs.GetString("ZoneName" + k.ToString()));
        }
    }

    public void Save()
    {
        WarmingUpSave();
        GameDataSaveKey();
        DataManager.Instance.SaveGameData();
    }

}
