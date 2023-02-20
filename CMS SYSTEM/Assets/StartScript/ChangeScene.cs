using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
    private void Awake()
    {
        Application.runInBackground = true; // 백그라운드에서 동작하는 기능, PC에서만 가능 
    }

    public void SettingBtnClik()
    {
        SceneManager.LoadScene("SettingScene"); // 설정 씬으로 이동
    }

    public void BackButton()
    {
        SceneManager.LoadScene("MainScene"); // 메인 씬으로 이동
    }

    public void BackStartButton()
    {
        SceneManager.LoadScene("StartScene"); // 스타트 씬으로 이동
    }

}
