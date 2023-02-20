using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RemoveList : MonoBehaviour, IPointerClickHandler
{
    public GameObject CancelMent;
    public Text CancelInfoText;
    public Button OkayButton;
    public GameObject ScrollView;

    bool CheckSign = false;
    public void OnPointerClick(PointerEventData eventData)
    {
        
        if (CheckSign == true)
        {
            if (this.gameObject.name == "InputFieldPrefab")
            {
                return;
            }

            CancelInfoText.text = this.gameObject.transform.GetChild(6).GetComponent<Text>().text + "번을 삭제하시겠습니까?";
            CancelMent.SetActive(true);

            switch (this.gameObject.name)
            {
                case "Clone2":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone3":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone4":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone5":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone6":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone7":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone8":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone9":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone10":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone11":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone12":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone13":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone14":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone15":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone16":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone17":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone18":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone19":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone20":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone21":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone22":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone23":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone24":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone25":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone26":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone27":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone28":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone29":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone30":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;
                case "Clone31":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone32":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone33":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone34":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone35":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone36":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone37":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone38":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone39":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone40":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone41":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone42":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone43":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone44":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone45":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone46":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone47":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone48":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone49":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone50":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone51":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone52":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone53":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone54":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone55":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;

                case "Clone56":
                    OkayButton.onClick.AddListener(Okaybutton);
                    break;
            }
        }
    }

    public void CheckSignTrue()
    {
        CheckSign= true;
    }

    public void CheckSignFalse()
    {
        CancelMent.SetActive(false);
        CheckSign = false;
    }

    public void ReturnButton()
    {
        CancelMent.SetActive(false);
    }

    public void Okaybutton()
    {
        switch (this.gameObject.name)
        {
            case "Clone2":
                OkayButton.onClick.RemoveListener(Okaybutton);
                break;

            case "Clone3":
                OkayButton.onClick.RemoveListener(Okaybutton);
                break;

            case "Clone4":
                OkayButton.onClick.RemoveListener(Okaybutton);
                break;

            case "Clone5":
                OkayButton.onClick.RemoveListener(Okaybutton);
                break;

            case "Clone6":
                OkayButton.onClick.RemoveListener(Okaybutton);
                break;

            case "Clone7":
                OkayButton.onClick.RemoveListener(Okaybutton);
                break;

            case "Clone8":
                OkayButton.onClick.RemoveListener(Okaybutton);
                break;

            case "Clone9":
                OkayButton.onClick.RemoveListener(Okaybutton);
                break;

            case "Clone10":
                OkayButton.onClick.RemoveListener(Okaybutton);
                break;

            case "Clone11":
                OkayButton.onClick.RemoveListener(Okaybutton);
                break;

            case "Clone12":
                OkayButton.onClick.RemoveListener(Okaybutton);
                break;

            case "Clone13":
                OkayButton.onClick.RemoveListener(Okaybutton);
                break;

            case "Clone14":
                OkayButton.onClick.RemoveListener(Okaybutton);
                break;

            case "Clone15":
                OkayButton.onClick.RemoveListener(Okaybutton);
                break;

            case "Clone16":
                OkayButton.onClick.RemoveListener(Okaybutton);
                break;

            case "Clone17":
                OkayButton.onClick.RemoveListener(Okaybutton);
                break;

            case "Clone18":
                OkayButton.onClick.RemoveListener(Okaybutton);
                break;

            case "Clone19":
                OkayButton.onClick.RemoveListener(Okaybutton);
                break;

            case "Clone20":
                OkayButton.onClick.RemoveListener(Okaybutton);
                break;

            case "Clone21":
                OkayButton.onClick.RemoveListener(Okaybutton);
                break;

            case "Clone22":
                OkayButton.onClick.RemoveListener(Okaybutton);
                break;

            case "Clone23":
                OkayButton.onClick.RemoveListener(Okaybutton);
                break;

            case "Clone24":
                OkayButton.onClick.RemoveListener(Okaybutton);
                break;

            case "Clone25":
                OkayButton.onClick.RemoveListener(Okaybutton);
                break;

            case "Clone26":
                OkayButton.onClick.RemoveListener(Okaybutton);
                break;

            case "Clone27":
                OkayButton.onClick.RemoveListener(Okaybutton);
                break;

            case "Clone28":
                OkayButton.onClick.RemoveListener(Okaybutton);
                break;

            case "Clone29":
                OkayButton.onClick.RemoveListener(Okaybutton);
                break;

            case "Clone30":
                OkayButton.onClick.RemoveListener(Okaybutton);
                break;
        }

        Destroy(this.gameObject);

        CheckSignFalse();

        ScrollView.SetActive(false);   

    }
}

