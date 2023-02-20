using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeveloperModeEnter : MonoBehaviour
{
    int i = 0;

    public GameObject DeveloperMode;
    public InputField Devel_IP;
    public InputField Devel_Port;
    public InputField Devel_Name;

    private void Start()
    {
        LoadPlayerPrefs();
    }

    void LoadPlayerPrefs()
    {
        Devel_IP.text = PlayerPrefs.GetString("Devel_IP");
        Devel_Port.text = PlayerPrefs.GetInt("Devel_Port").ToString();
        Devel_Name.text = PlayerPrefs.GetString("Devel_Name");
    }

    public void ReadySave()
    {
        PlayerPrefs.DeleteKey("Devel_IP");
        PlayerPrefs.DeleteKey("Devel_Port");

        PlayerPrefs.SetString("Devel_IP", Devel_IP.text);
        PlayerPrefs.SetInt("Devel_Port", int.Parse(Devel_Port.text));
        PlayerPrefs.SetString("Devel_Name", Devel_Name.text);
    }

    public void DBSave()
    {
        DataManager.Instance.data.Devel_IP = PlayerPrefs.GetString("Devel_IP");
        DataManager.Instance.data.Devel_Port = PlayerPrefs.GetInt("Devel_Port").ToString();
        DataManager.Instance.data.Devel_Name = PlayerPrefs.GetString("Devel_Name");
    }

    public void EnterDeveloperBtn()
    {
        ++i;

        if (i == 3)
        {
            DeveloperMode.SetActive(true);
        }
    }

    public void BackBtn()
    {
        i = 0;
        DeveloperMode.SetActive(false);
    }

    public void SaveBtn()
    {
        ReadySave();
        DBSave();
        DataManager.Instance.SaveGameData();
    }
}
