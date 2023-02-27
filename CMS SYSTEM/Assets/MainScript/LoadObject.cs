using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class LoadObject : MonoBehaviour
{
    public GameObject[] CMSList; // CMS �迭 
    public GameObject[] ZoneList;

    private void Awake()
    {
        Application.runInBackground = true; // ��׶��� ����
    }

    void Start()
    {
        DataManager.Instance.LoadGameData(); // ����� ������ �ҷ�����

        for (int i = 0; i < 56; i++)
        {
            if (DataManager.Instance.data.s[i] == false) // i�� ������ŭ �ݺ��Ͽ� false �����ΰŴ� �� ������ �ʵ��� ����
            {
                CMSList[i].gameObject.SetActive(false);
            }
        }
    }
}
