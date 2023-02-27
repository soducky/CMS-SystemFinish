using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeveloperModeEnter : MonoBehaviour // �����ڸ�� Ŭ���� - ��Ʈ��ũ ��ũ��Ʈ ���� - DeveloperModeEnter ������Ʈ
{

    public GameObject DeveloperMode;
    public InputField Devel_IP;
    public InputField Devel_Port;
    public InputField Devel_Name;

    private void Start()
    {
        LoadPlayerPrefs(); // ����� ������ �ҷ����� 
    }

    void LoadPlayerPrefs() 
    {
        Devel_IP.text = PlayerPrefs.GetString("Devel_IP");
        Devel_Port.text = PlayerPrefs.GetInt("Devel_Port").ToString();
        Devel_Name.text = PlayerPrefs.GetString("Devel_Name");
    }

    public void ReadySave() // ���̺� �Ҷ� �غ���� 
    {
        PlayerPrefs.DeleteKey("Devel_IP"); // ���� ������ ���� �� ���� 
        PlayerPrefs.DeleteKey("Devel_Port");
        PlayerPrefs.DeleteKey("Devel_Name");

        PlayerPrefs.SetString("Devel_IP", Devel_IP.text); // ��ǲ�ʵ��� ���� PlayerPrefs Ű�� ���� 
        PlayerPrefs.SetInt("Devel_Port", int.Parse(Devel_Port.text));
        PlayerPrefs.SetString("Devel_Name", Devel_Name.text);
    }

    public void DBSave()
    {
        DataManager.Instance.data.Devel_IP = PlayerPrefs.GetString("Devel_IP"); // �̱��� �ȿ� GetString�� �־���
        DataManager.Instance.data.Devel_Port = PlayerPrefs.GetInt("Devel_Port").ToString();
        DataManager.Instance.data.Devel_Name = PlayerPrefs.GetString("Devel_Name");
    }

    public void EnterDeveloperBtn() // ������ ��� ���� ��ư Ŭ��
    {

          DeveloperMode.SetActive(true); // ������ ��� â true

    }

    public void BackBtn() // �ڷ� ���� ��ư -> ���� �� �����ڸ�� â ����
    {
        SaveBtn(); // ����
        DeveloperMode.SetActive(false);  // ������ ��� â false
    }

    public void SaveBtn()
    {
        ReadySave();
        DBSave();
        DataManager.Instance.SaveGameData();
    }
}
