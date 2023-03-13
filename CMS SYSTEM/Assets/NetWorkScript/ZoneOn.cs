using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoneOn : MonoBehaviour
{
    public GameObject[] Zone1;
    public GameObject[] Zone2;
    public GameObject[] Zone3;
    public GameObject[] Zone4;
    public GameObject[] Zone5;
    public GameObject[] Zone6;
    public GameObject[] Zone7;

    public Image[] ZoneImgChange;
    public Sprite GreenLight;


    private void Update()
    {
        ZoneImgChangeMethod();

        for(int i=0; i<DataManager.Instance.data.i; i++)
        {
            if(DataManager.Instance.data.IPAddress[i] == "0")
            {
                DataManager.Instance.data.ZoneLight[i] = true;
            }
        }
    }

    void ZoneImgChangeMethod()
    {
        if (DataManager.Instance.data.ZoneLight[0] == true &&
            DataManager.Instance.data.ZoneLight[1] == true &&
            DataManager.Instance.data.ZoneLight[2] == true &&
            DataManager.Instance.data.ZoneLight[3] == true &&
            DataManager.Instance.data.ZoneLight[4] == true &&
            DataManager.Instance.data.ZoneLight[5] == true &&
            DataManager.Instance.data.ZoneLight[6] == true &&
            DataManager.Instance.data.ZoneLight[7] == true)
        {
            ZoneImgChange[0].sprite = GreenLight;
        }

        if (DataManager.Instance.data.ZoneLight[8] == true &&
            DataManager.Instance.data.ZoneLight[9] == true &&
            DataManager.Instance.data.ZoneLight[10] == true &&
            DataManager.Instance.data.ZoneLight[11] == true &&
            DataManager.Instance.data.ZoneLight[12] == true &&
            DataManager.Instance.data.ZoneLight[13] == true &&
            DataManager.Instance.data.ZoneLight[14] == true &&
            DataManager.Instance.data.ZoneLight[15] == true)
        {
            ZoneImgChange[1].sprite = GreenLight;
        }

        if (DataManager.Instance.data.ZoneLight[16] == true &&
            DataManager.Instance.data.ZoneLight[17] == true &&
            DataManager.Instance.data.ZoneLight[18] == true &&
            DataManager.Instance.data.ZoneLight[19] == true &&
            DataManager.Instance.data.ZoneLight[20] == true &&
            DataManager.Instance.data.ZoneLight[21] == true &&
            DataManager.Instance.data.ZoneLight[22] == true &&
            DataManager.Instance.data.ZoneLight[23] == true)
        {
            ZoneImgChange[2].sprite = GreenLight;
        }

        if (DataManager.Instance.data.ZoneLight[24] == true &&
            DataManager.Instance.data.ZoneLight[25] == true &&
            DataManager.Instance.data.ZoneLight[26] == true &&
            DataManager.Instance.data.ZoneLight[27] == true &&
            DataManager.Instance.data.ZoneLight[28] == true &&
            DataManager.Instance.data.ZoneLight[29] == true &&
            DataManager.Instance.data.ZoneLight[30] == true &&
            DataManager.Instance.data.ZoneLight[31] == true)
        {
            ZoneImgChange[3].sprite = GreenLight;
        }

        if (DataManager.Instance.data.ZoneLight[32] == true &&
            DataManager.Instance.data.ZoneLight[33] == true &&
            DataManager.Instance.data.ZoneLight[34] == true &&
            DataManager.Instance.data.ZoneLight[35] == true &&
            DataManager.Instance.data.ZoneLight[36] == true &&
            DataManager.Instance.data.ZoneLight[37] == true &&
            DataManager.Instance.data.ZoneLight[38] == true &&
            DataManager.Instance.data.ZoneLight[39] == true)
        {
            ZoneImgChange[4].sprite = GreenLight;
        }

        if (DataManager.Instance.data.ZoneLight[40] == true &&
            DataManager.Instance.data.ZoneLight[41] == true &&
            DataManager.Instance.data.ZoneLight[42] == true &&
            DataManager.Instance.data.ZoneLight[43] == true &&
            DataManager.Instance.data.ZoneLight[44] == true &&
            DataManager.Instance.data.ZoneLight[45] == true &&
            DataManager.Instance.data.ZoneLight[46] == true &&
            DataManager.Instance.data.ZoneLight[47] == true)
        {
            ZoneImgChange[5].sprite = GreenLight;
        }

        if (DataManager.Instance.data.ZoneLight[48] == true &&
            DataManager.Instance.data.ZoneLight[49] == true &&
            DataManager.Instance.data.ZoneLight[50] == true &&
            DataManager.Instance.data.ZoneLight[51] == true &&
            DataManager.Instance.data.ZoneLight[52] == true &&
            DataManager.Instance.data.ZoneLight[53] == true &&
            DataManager.Instance.data.ZoneLight[54] == true &&
            DataManager.Instance.data.ZoneLight[55] == true)
        {
            ZoneImgChange[6].sprite = GreenLight;
        }
    }
    public void Zone1OnBtnClik()
    {

        for (int i = 0; i <= Zone1.Length - 1; i++) 
        {
            if (DataManager.Instance.data.modeSelect[i] == false && DataManager.Instance.data.IPAddress[i] != "0")
            {
                Zone1[i].transform.GetChild(1).GetComponent<OnButtonClik>().OnBtnCapsule();
            }
        }

        Invoke("LaterPCOnZone1", float.Parse(DataManager.Instance.data.Devel_Time));
    }

    public void LaterPCOnZone1()
    {
        for (int i = 0; i <= Zone1.Length - 1; i++)
        {
            if (DataManager.Instance.data.modeSelect[i] == true && DataManager.Instance.data.IPAddress[i] != "0")
            {
                Zone1[i].transform.GetChild(1).GetComponent<OnButtonClik>().OnBtnCapsule();
            }
        }
    }
    public void Zone2OnBtnClik()
    {
        for (int i = 0; i <= 7; i++)
        {
            if (DataManager.Instance.data.modeSelect[i] == false && DataManager.Instance.data.IPAddress[i] != "0")
            {
                Zone2[i].transform.GetChild(1).GetComponent<OnButtonClik>().OnBtnCapsule();
            }
        }
        
        Invoke("LaterPCOnZone2", float.Parse(DataManager.Instance.data.Devel_Time));
    }

    public void LaterPCOnZone2()
    {
        for (int i = 0; i <= 7; i++)
        {
            if (DataManager.Instance.data.modeSelect[i] == true && DataManager.Instance.data.IPAddress[i] != "0")
            {
                Zone2[i].transform.GetChild(1).GetComponent<OnButtonClik>().OnBtnCapsule();
            }
        }
    }

    public void Zone3OnBtnClik()
    {
        for (int i = 0; i <= Zone3.Length - 1; i++)
        {
            if (DataManager.Instance.data.modeSelect[i] == false && DataManager.Instance.data.IPAddress[i] != "0")
            {
                Zone3[i].transform.GetChild(1).GetComponent<OnButtonClik>().OnBtnCapsule();
            }
        }

        Invoke("LaterPCOnZone3", float.Parse(DataManager.Instance.data.Devel_Time));
    }

    public void LaterPCOnZone3()
    {
        for (int i = 0; i <= Zone3.Length - 1; i++)
        {
            if (DataManager.Instance.data.modeSelect[i] == true && DataManager.Instance.data.IPAddress[i] != "0")
            {
                Zone3[i].transform.GetChild(1).GetComponent<OnButtonClik>().OnBtnCapsule();
            }
        }
    }

    public void Zone4OnBtnClik()
    {
        for (int i = 0; i <= Zone4.Length - 1; i++)
        {
            if (DataManager.Instance.data.modeSelect[i] == false && DataManager.Instance.data.IPAddress[i] != "0")
            {
                Zone4[i].transform.GetChild(1).GetComponent<OnButtonClik>().OnBtnCapsule();
            }
        }

        Invoke("LaterPCOnZone4", float.Parse(DataManager.Instance.data.Devel_Time));
    }

    public void LaterPCOnZone4()
    {
        for (int i = 0; i <= Zone4.Length-1; i++)
        {
            if (DataManager.Instance.data.modeSelect[i] == true && DataManager.Instance.data.IPAddress[i] != "0")
            {
                Zone4[i].transform.GetChild(1).GetComponent<OnButtonClik>().OnBtnCapsule();
            }
        }
    }

    public void Zone5OnBtnClik()
    {
        for (int i = 0; i <= Zone5.Length - 1; i++)
        {
            if (DataManager.Instance.data.modeSelect[i] == false && DataManager.Instance.data.IPAddress[i] != "0")
            {
                Zone5[i].transform.GetChild(1).GetComponent<OnButtonClik>().OnBtnCapsule();
            }
        }

        Invoke("LaterPCOnZone5", float.Parse(DataManager.Instance.data.Devel_Time));
    }

    public void LaterPCOnZone5()
    {
        for (int i = 0; i <= Zone5.Length - 1; i++)
        {
            if (DataManager.Instance.data.modeSelect[i] == true && DataManager.Instance.data.IPAddress[i] != "0")
            {
                Zone5[i].transform.GetChild(1).GetComponent<OnButtonClik>().OnBtnCapsule();
            }
        }
    }

    public void Zone6OnBtnClik()
    {
        for (int i = 0; i <= Zone6.Length - 1; i++)
        {
            if (DataManager.Instance.data.modeSelect[i] == false && DataManager.Instance.data.IPAddress[i] != "0")
            {
                Zone6[i].transform.GetChild(1).GetComponent<OnButtonClik>().OnBtnCapsule();
            }
        }

        Invoke("LaterPCOnZone6", float.Parse(DataManager.Instance.data.Devel_Time));
    }

    public void LaterPCOnZone6()
    {
        for (int i = 0; i <= Zone6.Length - 1; i++)
        {
            if (DataManager.Instance.data.modeSelect[i] == true && DataManager.Instance.data.IPAddress[i] != "0")
            {
                Zone6[i].transform.GetChild(1).GetComponent<OnButtonClik>().OnBtnCapsule();
            }
        }
    }

    public void Zone7OnBtnClik()
    {
        for (int i = 0; i <= Zone7.Length - 1; i++)
        {
            if (DataManager.Instance.data.modeSelect[i] == false && DataManager.Instance.data.IPAddress[i] != "0")
            {
                Zone7[i].transform.GetChild(1).GetComponent<OnButtonClik>().OnBtnCapsule();
            }
        }

        Invoke("LaterPCOnZone7", float.Parse(DataManager.Instance.data.Devel_Time));
    }

    public void LaterPCOnZone7()
    {
        for (int i = 0; i <= Zone7.Length - 1; i++)
        {
            if (DataManager.Instance.data.modeSelect[i] == true && DataManager.Instance.data.IPAddress[i] != "0")
            {
                Zone7[i].transform.GetChild(1).GetComponent<OnButtonClik>().OnBtnCapsule();
            }
        }
    }
}

