using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class AddButton : MonoBehaviour
{
    public GameObject OriginalPrefab;
    public Transform Parent;
    public GameObject WaringMent;

    // public Text[] NumberText = new Text[30];
    // public GameObject[] clone = new GameObject[30];

    public List<GameObject> clonelist = new List<GameObject>();
    public List<Text> numbertextlist = new List<Text>();
    public GameObject DeleteButton;
    public List<int> Valuelist = new List<int>();

    bool Switch = true;
    int j = 1;

    void Start()
    {
        for (int k=0; k < Valuelist.Count; k++)
        {
            Valuelist[k] = k+1;
        }

        StartLoadData();

    }

    private void Update()
    {
        if (clonelist.Count == 1)
        {
            DeleteButton.SetActive(false);
        }

        else
        {
            DeleteButton.SetActive(true);
        }
    }
    public void PrefabAddBtn()
    {
        if (Switch == true)
        {

          /*  clone[i] = Instantiate(OriginalPrefab, Parent);
            clone[i].name = "Clone" + NumMax[i].ToString();
            clone[i].transform.GetChild(6).name = "CloneNumber" + NumMax[i].ToString();
            clonelist = clone.ToList();
            Debug.Log(clonelist.Count);

            NumberText[i] = clone[i].transform.GetChild(6).GetComponent<Text>();
            NumberText[i].text = NumMax[i].ToString() + ".";
            numbertextlist = NumberText.ToList();
            Debug.Log(numbertextlist.Count);
          */

            clonelist.Add(Instantiate(OriginalPrefab,Parent));
            InputFiledNull();
            clonelist[j].name = "Clone" + Valuelist[j].ToString();

            numbertextlist.Add(clonelist[j].transform.GetChild(6).GetComponent<Text>());
            numbertextlist[j].name = "Clone" + Valuelist[j].ToString();
            numbertextlist[j].text = Valuelist[j].ToString();

            j++;
            DataManager.Instance.data.i++;

            if (j == 56)
            {
                Switch = false;
            }
        }

        else if(Switch == false)
        {
            WaringMent.SetActive(true);
            Invoke("TimeDelay", 2f);
        }
    }
    void TimeDelay()
    {
        WaringMent.SetActive(false);
    }

    public void MinusI()
    {
        j--;
        DataManager.Instance.data.i--;
        Switch = true;
    }

    public void StartLoadData()
    {
        DataManager.Instance.LoadGameData();

        for (int m = 1; m < DataManager.Instance.data.i; m++)
        {
            CopyAddButton();
        }

        GameObject.FindWithTag("InputField").GetComponent<InputData>().WarmingUpLoad();
    }

    public void CopyAddButton()
    {
        if (Switch == true)
        {

            /*  clone[i] = Instantiate(OriginalPrefab, Parent);
              clone[i].name = "Clone" + NumMax[i].ToString();
              clone[i].transform.GetChild(6).name = "CloneNumber" + NumMax[i].ToString();
              clonelist = clone.ToList();
              Debug.Log(clonelist.Count);

              NumberText[i] = clone[i].transform.GetChild(6).GetComponent<Text>();
              NumberText[i].text = NumMax[i].ToString() + ".";
              numbertextlist = NumberText.ToList();
              Debug.Log(numbertextlist.Count);
            */

            clonelist.Add(Instantiate(OriginalPrefab, Parent));
            clonelist[j].name = "Clone" + Valuelist[j].ToString();

            numbertextlist.Add(clonelist[j].transform.GetChild(6).GetComponent<Text>());
            numbertextlist[j].name = "Clone" + Valuelist[j].ToString();
            numbertextlist[j].text = Valuelist[j].ToString();

            j++;

            if (j == 56)
            {
                Switch = false;
            }
        }

        else if (Switch == false)
        {
            WaringMent.SetActive(true);
            Invoke("TimeDelay", 2f);
        }
    }

    void InputFiledNull()
    {
        clonelist[j].transform.GetChild(2).GetComponent<InputField>().text = null;
        clonelist[j].transform.GetChild(1).GetComponent<InputField>().text = null;
        clonelist[j].transform.GetChild(0).GetComponent<InputField>().text = null;
        clonelist[j].transform.GetChild(3).GetComponent<InputField>().text = "0";
        clonelist[j].transform.GetChild(7).GetComponent<InputField>().text = null;
    }
}

