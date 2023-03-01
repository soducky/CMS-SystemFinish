using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
    private void Awake()
    {
        Application.runInBackground = true; // ��׶��忡�� �����ϴ� ���, PC������ ���� 
    }

    public void SettingBtnClik()
    {
        DataManager.Instance.SaveGameData();
        SceneManager.LoadScene("SettingScene"); // ���� ������ �̵�
    }

    public void BackButton()
    {
        DataManager.Instance.SaveGameData();
        SceneManager.LoadScene("MainScene"); // ���� ������ �̵�
    }

    public void BackAndSaveButton() // �������������� ������������ �̵��� ������ ������ ���� 
    {
        GameObject.Find("InputFieldPrefab").GetComponent<InputData>().Save();  // ���� �� ���� ������ �̵�
        SceneManager.LoadScene("MainScene");
    }

    public void BackStartButton()
    {
        DataManager.Instance.SaveGameData();
        SceneManager.LoadScene("StartScene"); // ��ŸƮ ������ �̵�
    }

}
