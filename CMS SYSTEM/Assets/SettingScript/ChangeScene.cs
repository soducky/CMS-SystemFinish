using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
    private void Awake()
    {
        Application.runInBackground = true;
    }

    public void SettingBtnClik()
    {
        SceneManager.LoadScene("SettingScene");
     
    }

    public void BackButton()
    {
        SceneManager.LoadScene("MainScene");
    }

}
