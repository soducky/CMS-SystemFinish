using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;

public class DeleteButton : MonoBehaviour
{
    public Image scrollView; // ������� �϶��� ��ũ�� �� ������ ���������� �����ϱ� ���� 
    public BoxCollider2D InputFieldPrefab; // ������Ʈ ���� �Ȱ��� �ݶ��̴��� �߰��ϱ� ����
    public GameObject addButton; // ������� �϶� �߰���ư ��Ȱ��ȭ ��Ű�� ����
    public GameObject SaveButton; // �����ư 
    public GameObject ScrollView; // ��ũ�Ѻ� 
    public Button Deletebtn;

    public List<BoxCollider2D> boxcolliderlist = new List<BoxCollider2D>(); // �ݶ��̴����� ����Ʈ�� ����

    public bool count = false; // ������ư�� �� �ѹ��� ������ �ϱ� ���� 

    public void DeleteButtonClik() // ���� ��ư Ŭ����
    {
        if (count == false) // ó�� ������ ��Ҹ�� 
        {
            EnterDeleteMode();
        }

        else if (count == true) // �ι� ������ �������� ������
        {
            EnterAddMode();
        }

    }

    void ChangeColor()
    {
        if (count == false) // ��Ҹ���϶� ��ũ�Ѻ� ����
        {
            scrollView.color = new Color(231f / 255f, 100f / 255f, 100f / 255f, 100f / 255f);
        }
        else if (count == true) // �߰�����϶� ��ũ�Ѻ� ���� 
        {
            scrollView.color = new Color(0f / 255f, 0f / 255f, 0f / 255f, 100f / 255f);
        }
    }
    public void EnterDeleteMode() // ��� ��� ����
    {
        List<GameObject> clonelist = GameObject.FindWithTag("AddButton").GetComponent<AddButton>().clonelist; // Ŭ�и���Ʈ �ҷ�����

        addButton.SetActive(false);
        SaveButton.SetActive(false); // ��Ҹ�忡�� ������ �� �ִ� ��ư�� ��Ȱ��ȭ 

        GameObject.Find("InputFieldPrefab").GetComponent<RemoveList>().CheckSignTrue(); // ��� â�� �߰��ϴ� ����ġ (1�� ������Ʈ)

        for (int j = 1; j < clonelist.Count; j++)
        {
            GameObject.Find(clonelist[j].name).GetComponent<RemoveList>().CheckSignTrue(); // ��� â�� �߰��ϴ� ����ġ (1�� �̿��� ������Ʈ)
        } 

        ChangeColor(); // ���� �ٲٱ� 

        for (int k = 1; k <= clonelist.Count; k++) // clonelist�� ���� == ������Ʈ�� ���� 
        {
            boxcolliderlist.Add(clonelist[k].GetComponent<BoxCollider2D>());
            boxcolliderlist[k].name = clonelist[k].name;

            if (boxcolliderlist.Count == clonelist.Count) // �ΰ��� �����ÿ��� �Ϸ�Ȱ��̹Ƿ� ���� 
            {
                break;
            }
        }

        count = true;
    }

    public void EnterAddMode() // �߰����� ������ (�߰���� == ���� ���)
    {
        ScrollView.SetActive(true); // ��ũ�� Ȱ��ȭ
        ChangeColor(); // ���� ����
        addButton.SetActive(true); 
        SaveButton.SetActive(true); // ��ư�� Ȱ��ȭ 

        GameObject.Find("InputFieldPrefab").GetComponent<RemoveList>().CheckSignFalse(); // ���â �߰��ϴ� ����ġ false

        try
        {
            for (int j = 1; j < boxcolliderlist.Count; j++)
            {
                GameObject.Find(boxcolliderlist[j].name).GetComponent<RemoveList>().CheckSignFalse(); // ������ư�� 2������ ������ ��� 
            }
        }

        catch (Exception ex) // ���� - ������ư ������ �����ϰ� �ٽ� ������ư ������ ��� 
        {
            Debug.Log(ex);
            
            List<GameObject> clonelist = GameObject.FindWithTag("AddButton").GetComponent<AddButton>().clonelist;
            List<Text> numbertextlist = GameObject.FindWithTag("AddButton").GetComponent<AddButton>().numbertextlist;
            List<int> Valuelist = GameObject.FindWithTag("AddButton").GetComponent<AddButton>().Valuelist;

            foreach (var i in clonelist)
            {
                if (i == null)
                {
                    clonelist.Remove(i); // ���� �� i �� ����Ʈ���� ����� 
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
            } // �̰� �����ָ� ������ ������Ʈ���� �߰����(����)�϶��� ��Ҽ���â�� ������
            // ���⼭ �������� ������ ����� �ȵȰ�. ���� ����  

            for (int i = 1; i < clonelist.Count; i++)
            {
                clonelist[i].name = "Clone" + Valuelist[i].ToString();
                numbertextlist[i].name = "Clone" + Valuelist[i].ToString();
                numbertextlist[i].text = Valuelist[i].ToString(); // �����Ѱ� �о�� �̸���, ��ȣ ������
            }
            GameObject.FindWithTag("AddButton").GetComponent<AddButton>().MinusI(); // �����Ǿ����� addbutton ��ũ��Ʈ�� �ִ� i �� ���̳ʽ� 1 
            GameObject.FindWithTag("DeleteComplete").GetComponent<DeleteComplete>().DeleteCompleteMethod(); // ���� �ȳ� �޼��� �޼��� ȣ��
        }

        count = false; // ��ҹ�ư ������ Ƚ�� �ʱ�ȭ
        boxcolliderlist.Clear(); // ��Ҹ�忡�� �����Ƿ� �ڽ� �ݶ��̴� ����Ʈ ��ü ���� 
        boxcolliderlist.Add(InputFieldPrefab);
        // ���Ŀ� ��Ҹ�忡 �ٽ� ���� �� �����Ƿ� ���� ������ �ݶ��̴��� ������ ������ ��
      
    }

}

