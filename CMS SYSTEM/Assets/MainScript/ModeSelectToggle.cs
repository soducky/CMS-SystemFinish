using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ModeSelectToggle : MonoBehaviour
{
    Toggle ModeSelect;

    string slice;
    int tmp;


    void Start()
    {
        TitleTransfer();
        ModeSelect = GetComponent<Toggle>();
        ModeSelect.onValueChanged.AddListener(OnToggleValueChanged);
       // LoadToggleData();
    }

    public void OnToggleValueChanged(bool boolean)
    {
        if (boolean == true)
        {
            this.gameObject.transform.GetChild(2).GetComponent<Text>().text = "PC Mode";

            /* switch (this.gameObject.name)
             {
                 case "01_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[0] = true;
                     break;

                 case "02_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[1] = true;
                     break;

                 case "03_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[2] = true;
                     break;

                 case "04_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[3] = true;
                     break;

                 case "05_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[4] = true;
                     break;

                 case "06_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[5] = true;
                     break;

                 case "07_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[6] = true;
                     break;

                 case "08_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[7] = true;
                     break;

                 case "09_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[8] = true;
                     break;

                 case "10_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[9] = true;
                     break;

                 case "11_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[10] = true;
                     break;

                 case "12_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[11] = true;
                     break;

                 case "13_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[12] = true;
                     break;

                 case "14_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[13] = true;
                     break;

                 case "15_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[14] = true;
                     break;

                 case "16_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[15] = true;
                     break;

                 case "17_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[16] = true;
                     break;

                 case "18_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[17] = true;
                     break;

                 case "19_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[18] = true;
                     break;

                 case "20_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[19] = true;
                     break;

                 case "21_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[20] = true;
                     break;

                 case "22_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[21] = true;
                     break;

                 case "23_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[22] = true;
                     break;

                 case "24_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[23] = true;
                     break;

                 case "25_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[24] = true;
                     break;

                 case "26_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[25] = true;
                     break;

                 case "27_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[26] = true;
                     break;

                 case "28_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[27] = true;
                     break;

                 case "29_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[28] = true;
                     break;

                 case "30_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[29] = true;
                     break;

                 case "31_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[30] = true;
                     break;

                 case "32_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[31] = true;
                     break;

                 case "33_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[32] = true;
                     break;

                 case "34_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[33] = true;
                     break;

                 case "35_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[34] = true;
                     break;

                 case "36_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[35] = true;
                     break;

                 case "37_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[36] = true;
                     break;

                 case "38_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[37] = true;
                     break;

                 case "39_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[38] = true;
                     break;

                 case "40_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[39] = true;
                     break;

                 case "41_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[40] = true;
                     break;

                 case "42_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[41] = true;
                     break;

                 case "43_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[42] = true;
                     break;

                 case "44_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[43] = true;
                     break;

                 case "45_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[44] = true;
                     break;

                 case "46_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[45] = true;
                     break;

                 case "47_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[46] = true;
                     break;

                 case "48_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[47] = true;
                     break;

                 case "49_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[48] = true;
                     break;

                 case "50_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[49] = true;
                     break;

                 case "51_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[50] = true;
                     break;

                 case "52_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[51] = true;
                     break;

                 case "53_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[52] = true;
                     break;

                 case "54_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[53] = true;
                     break;

                 case "55_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[54] = true;
                     break;

                 case "56_CMS_Toggle":
                     DataManager.Instance.data.modeSelect[55] = true;
                     break;
             }*/

            DataManager.Instance.data.modeSelect[tmp - 1] = true;

            saveToggle();
        }

        else if (boolean == false)
        {
            this.gameObject.transform.GetChild(2).GetComponent<Text>().text = "PJ Mode";

            /*  switch (this.gameObject.name)
              {
                  case "01_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[0] = false;
                      break;

                  case "02_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[1] = false;
                      break;

                  case "03_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[2] = false;
                      break;

                  case "04_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[3] = false;
                      break;

                  case "05_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[4] = false;
                      break;

                  case "06_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[5] = false;
                      break;

                  case "07_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[6] = false;
                      break;

                  case "08_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[7] = false;
                      break;

                  case "09_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[8] = false;
                      break;

                  case "10_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[9] = false;
                      break;

                  case "11_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[10] = false;
                      break;

                  case "12_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[11] = false;
                      break;

                  case "13_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[12] = false;
                      break;

                  case "14_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[13] = false;
                      break;

                  case "15_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[14] = false;
                      break;

                  case "16_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[15] = false;
                      break;

                  case "17_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[16] = false;
                      break;

                  case "18_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[17] = false;
                      break;

                  case "19_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[18] = false;
                      break;

                  case "20_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[19] = false;
                      break;

                  case "21_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[20] = false;
                      break;

                  case "22_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[21] = false;
                      break;

                  case "23_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[22] = false;
                      break;

                  case "24_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[23] = false;
                      break;

                  case "25_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[24] = false;
                      break;

                  case "26_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[25] = false;
                      break;

                  case "27_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[26] = false;
                      break;

                  case "28_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[27] = false;
                      break;

                  case "29_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[28] = false;
                      break;

                  case "30_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[29] = false;
                      break;

                  case "31_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[30] = false;
                      break;

                  case "32_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[31] = false;
                      break;

                  case "33_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[32] = false;
                      break;

                  case "34_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[33] = false;
                      break;

                  case "35_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[34] = false;
                      break;

                  case "36_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[35] = false;
                      break;

                  case "37_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[36] = false;
                      break;

                  case "38_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[37] = false;
                      break;

                  case "39_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[38] = false;
                      break;

                  case "40_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[39] = false;
                      break;

                  case "41_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[40] = false;
                      break;

                  case "42_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[41] = false;
                      break;

                  case "43_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[42] = false;
                      break;

                  case "44_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[43] = false;
                      break;

                  case "45_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[44] = false;
                      break;

                  case "46_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[45] = false;
                      break;

                  case "47_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[46] = false;
                      break;

                  case "48_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[47] = false;
                      break;

                  case "49_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[48] = false;
                      break;

                  case "50_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[49] = false;
                      break;

                  case "51_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[50] = false;
                      break;

                  case "52_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[51] = false;
                      break;

                  case "53_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[52] = false;
                      break;

                  case "54_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[53] = false;
                      break;

                  case "55_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[54] = false;
                      break;

                  case "56_CMS_Toggle":
                      DataManager.Instance.data.modeSelect[55] = false;
                      break;
              }
            */

            DataManager.Instance.data.modeSelect[tmp - 1] = false;

            saveToggle();
        }
    }
/*
    public void LoadToggleData()
    {
        switch (this.gameObject.name)
        {
            case "01_CMS_Toggle":
                i = 0;
                ChangeUIToggle();
                break;

            case "02_CMS_Toggle":
                i = 1;
                ChangeUIToggle();
                break;

            case "03_CMS_Toggle":
                i = 2;
                ChangeUIToggle();
                break;

            case "04_CMS_Toggle":
                i = 3;
                ChangeUIToggle();
                break;

            case "05_CMS_Toggle":
                i = 4;
                ChangeUIToggle();
                break;

            case "06_CMS_Toggle":
                i = 5;
                ChangeUIToggle();
                break;

            case "07_CMS_Toggle":
                i = 6;
                ChangeUIToggle();
                break;

            case "08_CMS_Toggle":
                i = 7;
                ChangeUIToggle();
                break;

            case "09_CMS_Toggle":
                i = 8;
                ChangeUIToggle();
                break;

            case "10_CMS_Toggle":
                i = 9;
                ChangeUIToggle();
                break;

            case "11_CMS_Toggle":
                i = 10;
                ChangeUIToggle();
                break;

            case "12_CMS_Toggle":
                i = 11;
                ChangeUIToggle();
                break;

            case "13_CMS_Toggle":
                i = 12;
                ChangeUIToggle();
                break;

            case "14_CMS_Toggle":
                i = 13;
                ChangeUIToggle();
                break;

            case "15_CMS_Toggle":
                i = 14;
                ChangeUIToggle();
                break;

            case "16_CMS_Toggle":
                i = 15;
                ChangeUIToggle();
                break;

            case "17_CMS_Toggle":
                i = 16;
                ChangeUIToggle();
                break;

            case "18_CMS_Toggle":
                i = 17;
                ChangeUIToggle();
                break;

            case "19_CMS_Toggle":
                i = 18;
                ChangeUIToggle();
                break;

            case "20_CMS_Toggle":
                i = 19;
                ChangeUIToggle();
                break;

            case "21_CMS_Toggle":
                i = 20;
                ChangeUIToggle();
                break;

            case "22_CMS_Toggle":
                i = 21;
                ChangeUIToggle();
                break;

            case "23_CMS_Toggle":
                i = 22;
                ChangeUIToggle();
                break;

            case "24_CMS_Toggle":
                i = 23;
                ChangeUIToggle();
                break;

            case "25_CMS_Toggle":
                i = 24;
                ChangeUIToggle();
                break;

            case "26_CMS_Toggle":
                i = 25;
                ChangeUIToggle();
                break;

            case "27_CMS_Toggle":
                i = 26;
                ChangeUIToggle();
                break;

            case "28_CMS_Toggle":
                i = 27;
                ChangeUIToggle();
                break;

            case "29_CMS_Toggle":
                i = 28;
                ChangeUIToggle();
                break;

            case "30_CMS_Toggle":
                i = 29;
                ChangeUIToggle();
                break;

            case "31_CMS_Toggle":
                i = 30;
                ChangeUIToggle();
                break;

            case "32_CMS_Toggle":
                i = 31;
                ChangeUIToggle();
                break;

            case "33_CMS_Toggle":
                i = 32;
                ChangeUIToggle();
                break;

            case "34_CMS_Toggle":
                i = 33;
                ChangeUIToggle();
                break;

            case "35_CMS_Toggle":
                i = 34;
                ChangeUIToggle();
                break;

            case "36_CMS_Toggle":
                i = 35;
                ChangeUIToggle();
                break;

            case "37_CMS_Toggle":
                i = 36;
                ChangeUIToggle();
                break;

            case "38_CMS_Toggle":
                i = 37;
                ChangeUIToggle();
                break;

            case "39_CMS_Toggle":
                i = 38;
                ChangeUIToggle();
                break;

            case "40_CMS_Toggle":
                i = 39;
                ChangeUIToggle();
                break;

            case "41_CMS_Toggle":
                i = 40;
                ChangeUIToggle();
                break;

            case "42_CMS_Toggle":
                i = 41;
                ChangeUIToggle();
                break;

            case "43_CMS_Toggle":
                i = 42;
                ChangeUIToggle();
                break;

            case "44_CMS_Toggle":
                i = 43;
                ChangeUIToggle();
                break;

            case "45_CMS_Toggle":
                i = 44;
                ChangeUIToggle();
                break;

            case "46_CMS_Toggle":
                i = 45;
                ChangeUIToggle();
                break;

            case "47_CMS_Toggle":
                i = 46;
                ChangeUIToggle();
                break;

            case "48_CMS_Toggle":
                i = 47;
                ChangeUIToggle();
                break;

            case "49_CMS_Toggle":
                i = 48;
                ChangeUIToggle();
                break;

            case "50_CMS_Toggle":
                i = 49;
                ChangeUIToggle();
                break;

            case "51_CMS_Toggle":
                i = 50;
                ChangeUIToggle();
                break;

            case "52_CMS_Toggle":
                i = 51;
                ChangeUIToggle();
                break;

            case "53_CMS_Toggle":
                i = 52;
                ChangeUIToggle();
                break;

            case "54_CMS_Toggle":
                i = 53;
                ChangeUIToggle();
                break;

            case "55_CMS_Toggle":
                i = 54;
                ChangeUIToggle();
                break;

            case "56_CMS_Toggle":
                i = 55;
                ChangeUIToggle();
                break;
        }
    }
    public void ChangeUIToggle()
    {
        if (ModeSelect.isOn == false && DataManager.Instance.data.modeSelect[i] == false)
        {
            return;
        }

        else if (ModeSelect.isOn == false && DataManager.Instance.data.modeSelect[i] == true)
        {

            ModeSelect.isOn = true;
        
        }

        else if (ModeSelect.isOn == true && DataManager.Instance.data.modeSelect[i] == false)
        {
 
            ModeSelect.isOn = false;
   
        }

        else if (ModeSelect.isOn == true && DataManager.Instance.data.modeSelect[i] == true)
        {
            return;
        }
    }*/
     public void saveToggle()
    {
        DataManager.Instance.SaveGameData();
    }

     void TitleTransfer()
    {
        slice = this.gameObject.name;
        String substring = slice.Substring(0, 2);
        tmp = int.Parse(substring);
    }


}
