using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;

public class DeleteButton : MonoBehaviour
{
    public Image scrollView;
    public BoxCollider2D InputFieldPrefab;
    public GameObject addButton;
    public GameObject SaveButton;
    public GameObject ScrollView;

    public List<BoxCollider2D> boxcolliderlist = new List<BoxCollider2D>();

    public bool count = false;

    public void DeleteButtonClik()
    {
        if (count == false)
        {
            EnterDeleteMode();
        }

        else if (count == true)
        {
            EnterAddMode();
        }

    }

    void ChangeColor()
    {
        if (count == false)
        {
            scrollView.color = new Color(255f / 255f, 0f / 255f, 0f / 255f, 100f / 255f);
        }
        else if (count == true)
        {
            scrollView.color = new Color(255f / 255f, 255f / 255f, 255f / 255f, 100f / 255f);
        }
    }
    public void EnterDeleteMode()
    {
        List<GameObject> clonelist = GameObject.FindWithTag("AddButton").GetComponent<AddButton>().clonelist;

        addButton.SetActive(false);
        SaveButton.SetActive(false);

        GameObject.Find("InputFieldPrefab").GetComponent<RemoveList>().CheckSignTrue();

        for (int j = 1; j < clonelist.Count; j++)
        {
            GameObject.Find(clonelist[j].name).GetComponent<RemoveList>().CheckSignTrue();
        }

        ChangeColor();

        for (int k = 1; k <= clonelist.Count; k++)
        {
            boxcolliderlist.Add(clonelist[k].GetComponent<BoxCollider2D>());
            boxcolliderlist[k].name = clonelist[k].name;

            if (boxcolliderlist.Count == clonelist.Count)
            {
                break;
            }
        }

        count = true;
    }

    public void EnterAddMode()
    {
        ScrollView.SetActive(true);
        ChangeColor();
        addButton.SetActive(true);
        SaveButton.SetActive(true);
        GameObject.Find("InputFieldPrefab").GetComponent<RemoveList>().CheckSignFalse();

        try
        {
            for (int j = 1; j < boxcolliderlist.Count; j++)
            {
                GameObject.Find(boxcolliderlist[j].name).GetComponent<RemoveList>().CheckSignFalse();
            }
        }

        catch (Exception ex)
        {
            Debug.Log(ex);
            
            List<GameObject> clonelist = GameObject.FindWithTag("AddButton").GetComponent<AddButton>().clonelist;
            List<Text> numbertextlist = GameObject.FindWithTag("AddButton").GetComponent<AddButton>().numbertextlist;
            List<int> Valuelist = GameObject.FindWithTag("AddButton").GetComponent<AddButton>().Valuelist;

            foreach (var i in clonelist)
            {
                if (i == null)
                {
                    clonelist.Remove(i);
                    break;
                }
            }

            foreach (var i in numbertextlist)
            {
                if (i == null)
                {
                    numbertextlist.Remove(i);
                    break;
                }
            }

            foreach (var i in boxcolliderlist)
            {
                if (i == null)
                {
                    boxcolliderlist.Remove(i);
                    break;
                }
            }

            for (int j = 1; j < clonelist.Count; j++)
            {
                 GameObject.Find(clonelist[j].name).GetComponent<RemoveList>().CheckSignFalse();
            }

            for (int i = 1; i < clonelist.Count; i++)
            {
                clonelist[i].name = "Clone" + Valuelist[i].ToString();
                numbertextlist[i].name = "Clone" + Valuelist[i].ToString();
                numbertextlist[i].text = Valuelist[i].ToString();
            }
            GameObject.FindWithTag("AddButton").GetComponent<AddButton>().MinusI();
        }

        count = false;
        boxcolliderlist.Clear();
        boxcolliderlist.Add(InputFieldPrefab);
    }
}

