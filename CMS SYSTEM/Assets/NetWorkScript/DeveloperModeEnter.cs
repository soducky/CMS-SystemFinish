using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeveloperModeEnter : MonoBehaviour // 관리자모드 클래스 - 네트워크 스크립트 폴더 - DeveloperModeEnter 오브젝트
{

    public GameObject DeveloperMode;
    public InputField Devel_IP;
    public InputField Devel_Port;
    public InputField Devel_Name;

    private void Start()
    {
        LoadPlayerPrefs(); // 저장된 데이터 불러오기 
    }

    void LoadPlayerPrefs() 
    {
        Devel_IP.text = PlayerPrefs.GetString("Devel_IP");
        Devel_Port.text = PlayerPrefs.GetInt("Devel_Port").ToString();
        Devel_Name.text = PlayerPrefs.GetString("Devel_Name");
    }

    public void ReadySave() // 세이브 할때 준비과정 
    {
        PlayerPrefs.DeleteKey("Devel_IP"); // 기존 데이터 삭제 후 저장 
        PlayerPrefs.DeleteKey("Devel_Port");
        PlayerPrefs.DeleteKey("Devel_Name");

        PlayerPrefs.SetString("Devel_IP", Devel_IP.text); // 인풋필드의 값을 PlayerPrefs 키에 저장 
        PlayerPrefs.SetInt("Devel_Port", int.Parse(Devel_Port.text));
        PlayerPrefs.SetString("Devel_Name", Devel_Name.text);
    }

    public void DBSave()
    {
        DataManager.Instance.data.Devel_IP = PlayerPrefs.GetString("Devel_IP"); // 싱글톤 안에 GetString을 넣어줌
        DataManager.Instance.data.Devel_Port = PlayerPrefs.GetInt("Devel_Port").ToString();
        DataManager.Instance.data.Devel_Name = PlayerPrefs.GetString("Devel_Name");
    }

    public void EnterDeveloperBtn() // 관리자 모드 들어가는 버튼 클릭
    {

          DeveloperMode.SetActive(true); // 관리자 모드 창 true

    }

    public void BackBtn() // 뒤로 가기 버튼 -> 저장 후 관리자모드 창 끄기
    {
        SaveBtn(); // 저장
        DeveloperMode.SetActive(false);  // 관리자 모드 창 false
    }

    public void SaveBtn()
    {
        ReadySave();
        DBSave();
        DataManager.Instance.SaveGameData();
    }
}
