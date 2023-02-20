using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class SelectToggle : MonoBehaviour
{
    public GameObject cms_solo;
    Toggle Toggle_solo;

    string slice;
    int tmp;

    private void Start()
    {
        TitleTransfer();
        Toggle_solo = GetComponent<Toggle>();
        Togglestart();
        LoadToggleData();
    }

    public void Togglestart()
    {
        Toggle_solo.onValueChanged.AddListener(OnToggleValueChanged);
    }

    public void OnToggleValueChanged(bool boolean)
    {

        if (boolean == true)
        {
            cms_solo.SetActive(true);

            DataManager.Instance.data.s[tmp - 1] = true;
        }


        else if (boolean == false)
        {
            cms_solo.SetActive(false);

            DataManager.Instance.data.s[tmp - 1] = false;
        }
    }

    public void LoadToggleData()
    {

        if (Toggle_solo.isOn == false && DataManager.Instance.data.s[tmp-1] == false)
        {
            return;
        }

        else if (Toggle_solo.isOn == false && DataManager.Instance.data.s[tmp - 1] == true)
        {
            Toggle_solo.isOn = true;
        }

        else if (Toggle_solo.isOn == true && DataManager.Instance.data.s[tmp - 1] == false)
        {
            Toggle_solo.isOn = false;
        }

        else if (Toggle_solo.isOn == true && DataManager.Instance.data.s[tmp - 1] == true)
        {
            return;
        }
    }
        /*
            public void OnToggleValueChanged(bool boolean)
            {
                if (boolean == true)
                {
                   cms_solo.SetActive(true);

                   switch (this.gameObject.name)
                   {
                      case "Toggle01":
                           DataManager.Instance.data.s[0] = true;
                           break;

                      case "Toggle02":
                           DataManager.Instance.data.s[1] = true;
                           break;

                        case"Toggle03":
                            DataManager.Instance.data.s[2] = true;
                            break;

                        case"Toggle04":
                            DataManager.Instance.data.s[3] = true;
                            break;

                        case"Toggle05":
                            DataManager.Instance.data.s[4] = true;
                            break;

                        case"Toggle06":
                            DataManager.Instance.data.s[5] = true;
                            break;

                        case"Toggle07":
                            DataManager.Instance.data.s[6] = true;
                            break;

                        case"Toggle08":
                            DataManager.Instance.data.s[7] = true;
                            break;

                        case "Toggle09":
                            DataManager.Instance.data.s[8] = true;
                            break;

                        case "Toggle10":
                            DataManager.Instance.data.s[9] = true;
                            break;

                        case "Toggle11":
                            DataManager.Instance.data.s[10] = true;
                            break;

                        case "Toggle12":
                            DataManager.Instance.data.s[11] = true;
                            break;

                        case "Toggle13":
                            DataManager.Instance.data.s[12] = true;
                            break;

                        case "Toggle14":
                            DataManager.Instance.data.s[13] = true;
                            break;

                        case "Toggle15":
                            DataManager.Instance.data.s[14] = true;
                            break;

                        case "Toggle16":
                            DataManager.Instance.data.s[15] = true;
                            break;

                        case "Toggle17":
                            DataManager.Instance.data.s[16] = true;
                            break;

                        case "Toggle18":
                            DataManager.Instance.data.s[17] = true;
                            break;

                        case "Toggle19":
                            DataManager.Instance.data.s[18] = true;
                            break;

                        case "Toggle20":
                            DataManager.Instance.data.s[19] = true;
                            break;

                        case "Toggle21":
                            DataManager.Instance.data.s[20] = true;
                            break;

                        case "Toggle22":
                            DataManager.Instance.data.s[21] = true;
                            break;

                        case "Toggle23":
                            DataManager.Instance.data.s[22] = true;
                            break;

                        case "Toggle24":
                            DataManager.Instance.data.s[23] = true;
                            break;

                        case "Toggle25":
                            DataManager.Instance.data.s[24] = true;
                            break;

                        case "Toggle26":
                            DataManager.Instance.data.s[25] = true;
                            break;

                        case "Toggle27":
                            DataManager.Instance.data.s[26] = true;
                            break;

                        case "Toggle28":
                            DataManager.Instance.data.s[27] = true;
                            break;

                        case "Toggle29":
                            DataManager.Instance.data.s[28] = true;
                            break;

                        case "Toggle30":
                            DataManager.Instance.data.s[29] = true;
                            break;

                        case "Toggle31":
                            DataManager.Instance.data.s[30] = true;
                            break;

                        case "Toggle32":
                            DataManager.Instance.data.s[31] = true;
                            break;

                        case "Toggle33":
                            DataManager.Instance.data.s[32] = true;
                            break;

                        case "Toggle34":
                            DataManager.Instance.data.s[33] = true;
                            break;

                        case "Toggle35":
                            DataManager.Instance.data.s[34] = true;
                            break;

                        case "Toggle36":
                            DataManager.Instance.data.s[35] = true;
                            break;

                        case "Toggle37":
                            DataManager.Instance.data.s[36] = true;
                            break;

                        case "Toggle38":
                            DataManager.Instance.data.s[37] = true;
                            break;

                        case "Toggle39":
                            DataManager.Instance.data.s[38] = true;
                            break;

                        case "Toggle40":
                            DataManager.Instance.data.s[39] = true;
                            break;

                        case "Toggle41":
                            DataManager.Instance.data.s[40] = true;
                            break;

                        case "Toggle42":
                            DataManager.Instance.data.s[41]= true;
                            break;

                        case "Toggle43":
                            DataManager.Instance.data.s[42] = true;
                            break;

                        case "Toggle44":
                            DataManager.Instance.data.s[43] = true;
                            break;

                        case "Toggle45":
                            DataManager.Instance.data.s[44] = true;
                            break;

                        case "Toggle46":
                            DataManager.Instance.data.s[45] = true;
                            break;

                        case "Toggle47":
                            DataManager.Instance.data.s[46] = true;
                            break;

                        case "Toggle48":
                            DataManager.Instance.data.s[47] = true;
                            break;

                        case "Toggle49":
                            DataManager.Instance.data.s[48] = true;
                            break;

                        case "Toggle50":
                            DataManager.Instance.data.s[49] = true;
                            break;

                        case "Toggle51":
                            DataManager.Instance.data.s[50] = true;
                            break;

                        case "Toggle52":
                            DataManager.Instance.data.s[51] = true;
                            break;

                        case "Toggle53":
                            DataManager.Instance.data.s[52] = true;
                            break;

                        case "Toggle54":
                            DataManager.Instance.data.s[53] = true;
                            break;

                        case "Toggle55":
                            DataManager.Instance.data.s[54] = true;
                            break;

                        case "Toggle56":
                            DataManager.Instance.data.s[55] = true;
                            break;
                    }

                }

                else if (boolean == false)
                {
                     cms_solo.SetActive(false);
                    switch (this.gameObject.name)
                    {
                        case "Toggle01":
                            DataManager.Instance.data.s[0] = false;
                            break;

                        case "Toggle02":
                            DataManager.Instance.data.s[1] = false;
                            break;

                        case "Toggle03":
                            DataManager.Instance.data.s[2] = false;
                            break;

                        case "Toggle04":
                            DataManager.Instance.data.s[3] = false;
                            break;

                        case "Toggle05":
                            DataManager.Instance.data.s[4] = false;
                            break;

                        case "Toggle06":
                            DataManager.Instance.data.s[5] = false;
                            break;

                        case "Toggle07":
                            DataManager.Instance.data.s[6] = false;
                            break;

                        case "Toggle08":
                            DataManager.Instance.data.s[7] = false;
                            break;

                        case "Toggle09":
                            DataManager.Instance.data.s[8] = false;
                            break;

                        case "Toggle10":
                            DataManager.Instance.data.s[9] = false;
                            break;

                        case "Toggle11":
                            DataManager.Instance.data.s[10] = false;
                            break;

                        case "Toggle12":
                            DataManager.Instance.data.s[11] = false;
                            break;

                        case "Toggle13":
                            DataManager.Instance.data.s[12] = false;
                            break;

                        case "Toggle14":
                            DataManager.Instance.data.s[13] = false;
                            break;

                        case "Toggle15":
                            DataManager.Instance.data.s[14] = false;
                            break;

                        case "Toggle16":
                            DataManager.Instance.data.s[15] = false;
                            break;

                        case "Toggle17":
                            DataManager.Instance.data.s[16] = false;
                            break;

                        case "Toggle18":
                            DataManager.Instance.data.s[17] = false;
                            break;

                        case "Toggle19":
                            DataManager.Instance.data.s[18] = false;
                            break;

                        case "Toggle20":
                            DataManager.Instance.data.s[19] = false;
                            break;

                        case "Toggle21":
                            DataManager.Instance.data.s[20] = false;
                            break;

                        case "Toggle22":
                            DataManager.Instance.data.s[21] = false;
                            break;

                        case "Toggle23":
                            DataManager.Instance.data.s[22] = false;
                            break;

                        case "Toggle24":
                            DataManager.Instance.data.s[23] = false;
                            break;

                        case "Toggle25":
                            DataManager.Instance.data.s[24] = false;
                            break;

                        case "Toggle26":
                            DataManager.Instance.data.s[25] = false;
                            break;

                        case "Toggle27":
                            DataManager.Instance.data.s[26] = false;
                            break;

                        case "Toggle28":
                            DataManager.Instance.data.s[27] = false;
                            break;

                        case "Toggle29":
                            DataManager.Instance.data.s[28] = false;
                            break;

                        case "Toggle30":
                            DataManager.Instance.data.s[29] = false;
                            break;

                        case "Toggle31":
                            DataManager.Instance.data.s[30] = false;
                            break;

                        case "Toggle32":
                            DataManager.Instance.data.s[31] = false;
                            break;

                        case "Toggle33":
                            DataManager.Instance.data.s[32] = false;
                            break;

                        case "Toggle34":
                            DataManager.Instance.data.s[33] = false;
                            break;

                        case "Toggle35":
                            DataManager.Instance.data.s[34] = false;
                            break;

                        case "Toggle36":
                            DataManager.Instance.data.s[35] = false;
                            break;

                        case "Toggle37":
                            DataManager.Instance.data.s[36] = false;
                            break;

                        case "Toggle38":
                            DataManager.Instance.data.s[37] = false;
                            break;

                        case "Toggle39":
                            DataManager.Instance.data.s[38] = false;
                            break;

                        case "Toggle40":
                            DataManager.Instance.data.s[39] = false;
                            break;

                        case "Toggle41":
                            DataManager.Instance.data.s[40] = false;
                            break;

                        case "Toggle42":
                            DataManager.Instance.data.s[41] = false;
                            break;

                        case "Toggle43":
                            DataManager.Instance.data.s[42] = false;
                            break;

                        case "Toggle44":
                            DataManager.Instance.data.s[43] = false;
                            break;

                        case "Toggle45":
                            DataManager.Instance.data.s[44] = false;
                            break;

                        case "Toggle46":
                            DataManager.Instance.data.s[45] = false;
                            break;

                        case "Toggle47":
                            DataManager.Instance.data.s[46] = false;
                            break;

                        case "Toggle48":
                            DataManager.Instance.data.s[47] = false;
                            break;

                        case "Toggle49":
                            DataManager.Instance.data.s[48] = false;
                            break;

                        case "Toggle50":
                            DataManager.Instance.data.s[49] = false;
                            break;

                        case "Toggle51":
                            DataManager.Instance.data.s[50] = false;
                            break;

                        case "Toggle52":
                            DataManager.Instance.data.s[51] = false;
                            break;

                        case "Toggle53":
                            DataManager.Instance.data.s[52] = false;
                            break;

                        case "Toggle54":
                            DataManager.Instance.data.s[53] = false;
                            break;

                        case "Toggle55":
                            DataManager.Instance.data.s[54] = false;
                            break;

                        case "Toggle56":
                            DataManager.Instance.data.s[55] = false;
                            break;
                    }
                }
            }
            public void LoadToggleData()
            {
                switch (this.gameObject.name)
                {
                    case "Toggle01":
                        i = 0;
                        ChangeI();
                        break;

                    case "Toggle02":
                        i = 1;
                        ChangeI();
                        break;

                    case "Toggle03":
                        i = 2;
                        ChangeI();
                        break;

                    case "Toggle04":
                        i = 3;
                        ChangeI();
                        break;

                    case "Toggle05":
                        i = 4;
                        ChangeI();
                        break;

                    case "Toggle06":
                        i = 5;
                        ChangeI();
                        break;

                    case "Toggle07":
                        i = 6;
                        ChangeI();
                        break;

                    case "Toggle08":
                        i = 7;
                        ChangeI();
                        break;

                    case "Toggle09":
                        i = 8;
                        ChangeI();
                        break;

                    case "Toggle10":
                        i = 9;
                        ChangeI();
                        break;

                    case "Toggle11":
                        i = 10;
                        ChangeI();
                        break;

                    case "Toggle12":
                        i = 11;
                        ChangeI();
                        break;

                    case "Toggle13":
                        i = 12;
                        ChangeI();
                        break;

                    case "Toggle14":
                        i = 13;
                        ChangeI();
                        break;

                    case "Toggle15":
                        i = 14;
                        ChangeI();
                        break;

                    case "Toggle16":
                        i = 15;
                        ChangeI();
                        break;

                    case "Toggle17":
                        i = 16;
                        ChangeI();
                        break;

                    case "Toggle18":
                        i = 17;
                        ChangeI();
                        break;

                    case "Toggle19":
                        i = 18;
                        ChangeI();
                        break;

                    case "Toggle20":
                        i = 19;
                        ChangeI();
                        break;

                    case "Toggle21":
                        i = 20;
                        ChangeI();
                        break;

                    case "Toggle22":
                        i = 21;
                        ChangeI();
                        break;

                    case "Toggle23":
                        i = 22;
                        ChangeI();
                        break;

                    case "Toggle24":
                        i = 23;
                        ChangeI();
                        break;

                    case "Toggle25":
                        i = 24;
                        ChangeI();
                        break;

                    case "Toggle26":
                        i = 25;
                        ChangeI();
                        break;

                    case "Toggle27":
                        i = 26;
                        ChangeI();
                        break;

                    case "Toggle28":
                        i = 27;
                        ChangeI();
                        break;

                    case "Toggle29":
                        i = 28;
                        ChangeI();
                        break;

                    case "Toggle30":
                        i = 29;
                        ChangeI();
                        break;

                    case "Toggle31":
                        i = 30;
                        ChangeI();
                        break;

                    case "Toggle32":
                        i = 31;
                        ChangeI();
                        break;

                    case "Toggle33":
                        i = 32;
                        ChangeI();
                        break;

                    case "Toggle34":
                        i = 33;
                        ChangeI();
                        break;

                    case "Toggle35":
                        i = 34;
                        ChangeI();
                        break;

                    case "Toggle36":
                        i = 35;
                        ChangeI();
                        break;

                    case "Toggle37":
                        i = 36;
                        ChangeI();
                        break;

                    case "Toggle38":
                        i = 37;
                        ChangeI();
                        break;

                    case "Toggle39":
                        i = 38;
                        ChangeI();
                        break;

                    case "Toggle40":
                        i = 39;
                        ChangeI();
                        break;

                    case "Toggle41":
                        i = 40;
                        ChangeI();
                        break;

                    case "Toggle42":
                        i = 41;
                        ChangeI();
                        break;

                    case "Toggle43":
                        i = 42;
                        ChangeI();
                        break;

                    case "Toggle44":
                        i = 43;
                        ChangeI();
                        break;

                    case "Toggle45":
                        i = 44;
                        ChangeI();
                        break;

                    case "Toggle46":
                        i = 45;
                        ChangeI();
                        break;

                    case "Toggle47":
                        i = 46;
                        ChangeI();
                        break;

                    case "Toggle48":
                        i = 47;
                        ChangeI();
                        break;

                    case "Toggle49":
                        i = 48;
                        ChangeI();
                        break;

                    case "Toggle50":
                        i = 49;
                        ChangeI();
                        break;

                    case "Toggle51":
                        i = 50;
                        ChangeI();
                        break;

                    case "Toggle52":
                        i = 51;
                        ChangeI();
                        break;

                    case "Toggle53":
                        i = 52;
                        ChangeI();
                        break;

                    case "Toggle54":
                        i = 53;
                        ChangeI();
                        break;

                    case "Toggle55":
                        i = 54;
                        ChangeI();
                        break;

                    case "Toggle56":
                        i = 55;
                        ChangeI();
                        break;
                }
            }

             public void ChangeI()
            {
                if (Toggle_solo.isOn == false && DataManager.Instance.data.s[i] == false)
                {
                    return;
                }

                else if (Toggle_solo.isOn == false && DataManager.Instance.data.s[i] == true)
                {
                    Toggle_solo.isOn = true;
                }

                else if (Toggle_solo.isOn == true && DataManager.Instance.data.s[i] == false)
                {
                    Toggle_solo.isOn = false;
                }

                else if (Toggle_solo.isOn == true && DataManager.Instance.data.s[i] == true)
                {
                    return;
                }
            }
           */
    public void Save()
    {
       DataManager.Instance.SaveGameData();
    }

     void TitleTransfer()
    {
        slice = this.gameObject.name;
        String substring = slice.Substring(6, 2);
        tmp = int.Parse(substring);
    }
}
