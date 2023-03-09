using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoneOff : MonoBehaviour
{
    public GameObject[] Zone1;
    public GameObject[] Zone2;
    public GameObject[] Zone3;
    public GameObject[] Zone4;
    public GameObject[] Zone5;
    public GameObject[] Zone6;
    public GameObject[] Zone7;

    public Image[] ZoneImgReCh;
    public Sprite RedLight;

    private void Update()
    {
        ZoneImgReChangeMethod();
    }

    void ZoneImgReChangeMethod()
    {
        if (DataManager.Instance.data.ZoneLight[0] == false ||
            DataManager.Instance.data.ZoneLight[1] == false ||
            DataManager.Instance.data.ZoneLight[2] == false ||
            DataManager.Instance.data.ZoneLight[3] == false ||
            DataManager.Instance.data.ZoneLight[4] == false ||
            DataManager.Instance.data.ZoneLight[5] == false ||
            DataManager.Instance.data.ZoneLight[6] == false ||
            DataManager.Instance.data.ZoneLight[7] == false)
        {
            ZoneImgReCh[0].sprite = RedLight;
        }

        if (DataManager.Instance.data.ZoneLight[8] == false ||
            DataManager.Instance.data.ZoneLight[9] == false ||
            DataManager.Instance.data.ZoneLight[10] == false ||
            DataManager.Instance.data.ZoneLight[11] == false ||
            DataManager.Instance.data.ZoneLight[12] == false ||
            DataManager.Instance.data.ZoneLight[13] == false ||
            DataManager.Instance.data.ZoneLight[14] == false ||
            DataManager.Instance.data.ZoneLight[15] == false)
        {
            ZoneImgReCh[1].sprite = RedLight;
        }

        if (DataManager.Instance.data.ZoneLight[16] == false ||
            DataManager.Instance.data.ZoneLight[17] == false ||
            DataManager.Instance.data.ZoneLight[18] == false ||
            DataManager.Instance.data.ZoneLight[19] == false ||
            DataManager.Instance.data.ZoneLight[20] == false ||
            DataManager.Instance.data.ZoneLight[21] == false ||
            DataManager.Instance.data.ZoneLight[22] == false ||
            DataManager.Instance.data.ZoneLight[23] == false)
        {
            ZoneImgReCh[2].sprite = RedLight;
        }

        if (DataManager.Instance.data.ZoneLight[24] == false ||
            DataManager.Instance.data.ZoneLight[25] == false ||
            DataManager.Instance.data.ZoneLight[26] == false ||
            DataManager.Instance.data.ZoneLight[27] == false ||
            DataManager.Instance.data.ZoneLight[28] == false ||
            DataManager.Instance.data.ZoneLight[29] == false ||
            DataManager.Instance.data.ZoneLight[30] == false ||
            DataManager.Instance.data.ZoneLight[31] == false)
        {
            ZoneImgReCh[3].sprite = RedLight;
        }

        if (DataManager.Instance.data.ZoneLight[32] == false ||
            DataManager.Instance.data.ZoneLight[33] == false ||
            DataManager.Instance.data.ZoneLight[34] == false ||
            DataManager.Instance.data.ZoneLight[35] == false ||
            DataManager.Instance.data.ZoneLight[36] == false ||
            DataManager.Instance.data.ZoneLight[37] == false ||
            DataManager.Instance.data.ZoneLight[38] == false ||
            DataManager.Instance.data.ZoneLight[39] == false)
        {
            ZoneImgReCh[4].sprite = RedLight;
        }

        if (DataManager.Instance.data.ZoneLight[40] == false ||
            DataManager.Instance.data.ZoneLight[41] == false ||
            DataManager.Instance.data.ZoneLight[42] == false ||
            DataManager.Instance.data.ZoneLight[43] == false ||
            DataManager.Instance.data.ZoneLight[44] == false ||
            DataManager.Instance.data.ZoneLight[45] == false ||
            DataManager.Instance.data.ZoneLight[46] == false ||
            DataManager.Instance.data.ZoneLight[47] == false)
        {
            ZoneImgReCh[5].sprite = RedLight;
        }

        if (DataManager.Instance.data.ZoneLight[48] == false ||
            DataManager.Instance.data.ZoneLight[49] == false ||
            DataManager.Instance.data.ZoneLight[50] == false ||
            DataManager.Instance.data.ZoneLight[51] == false ||
            DataManager.Instance.data.ZoneLight[52] == false ||
            DataManager.Instance.data.ZoneLight[53] == false ||
            DataManager.Instance.data.ZoneLight[54] == false ||
            DataManager.Instance.data.ZoneLight[55] == false)
        {
            ZoneImgReCh[6].sprite = RedLight;
        }
    }

    public void Zone1OffBtnClik()
    {
        for (int i = 0; i <= Zone1.Length - 1; i++)
        {
            if (DataManager.Instance.data.modeSelect[i] == true && DataManager.Instance.data.IPAddress[i] != "0")
            {
                Zone1[i].transform.GetChild(2).GetComponent<OffButtonClik>().OffBtnCapsule();
            }
        }

        Invoke("LaterPJOffZone1", float.Parse(DataManager.Instance.data.Devel_Time));
    }

    public void LaterPJOffZone1()
    {
        for (int i = 0; i <= Zone1.Length - 1; i++)
        {
            if (DataManager.Instance.data.modeSelect[i] == false && DataManager.Instance.data.IPAddress[i] != "0")
            {
                Zone1[i].transform.GetChild(2).GetComponent<OffButtonClik>().OffBtnCapsule();
            }
        }
    }

    public void Zone2OffBtnClik()
    {
        for (int i = 0; i <= Zone2.Length - 1; i++)
        {
            if (DataManager.Instance.data.modeSelect[i] == true && DataManager.Instance.data.IPAddress[i] != "0")
            {
                Zone2[i].transform.GetChild(2).GetComponent<OffButtonClik>().OffBtnCapsule();
            }
        }

        Invoke("LaterPJOffZone2", float.Parse(DataManager.Instance.data.Devel_Time));
    }

    public void LaterPJOffZone2()
    {
        for (int i = 0; i <= Zone2.Length - 1; i++)
        {
            if (DataManager.Instance.data.modeSelect[i] == false && DataManager.Instance.data.IPAddress[i] != "0")
            {
                Zone2[i].transform.GetChild(2).GetComponent<OffButtonClik>().OffBtnCapsule();
            }
        }
    }
    public void Zone3OffBtnClik()
    {
        for (int i = 0; i <= Zone3.Length - 1; i++)
        {
            if (DataManager.Instance.data.modeSelect[i] == true && DataManager.Instance.data.IPAddress[i] != "0")
            {
                Zone3[i].transform.GetChild(2).GetComponent<OffButtonClik>().OffBtnCapsule();
            }
        }

        Invoke("LaterPJOffZone3", float.Parse(DataManager.Instance.data.Devel_Time));
    }

    public void LaterPJOffZone3()
    {
        for (int i = 0; i <= Zone3.Length - 1; i++)
        {
            if (DataManager.Instance.data.modeSelect[i] == false && DataManager.Instance.data.IPAddress[i] != "0")
            {
                Zone3[i].transform.GetChild(2).GetComponent<OffButtonClik>().OffBtnCapsule();
            }
        }
    }

    public void Zone4OffBtnClik()
    {
        for (int i = 0; i <= Zone4.Length - 1; i++)
        {
            if (DataManager.Instance.data.modeSelect[i] == true && DataManager.Instance.data.IPAddress[i] != "0")
            {
                Zone4[i].transform.GetChild(2).GetComponent<OffButtonClik>().OffBtnCapsule();
            }
        }

        Invoke("LaterPJOffZone4", float.Parse(DataManager.Instance.data.Devel_Time));
    }

    public void LaterPJOffZone4()
    {
        for (int i = 0; i <= Zone4.Length - 1; i++)
        {
            if (DataManager.Instance.data.modeSelect[i] == false && DataManager.Instance.data.IPAddress[i] != "0")
            {
                Zone4[i].transform.GetChild(2).GetComponent<OffButtonClik>().OffBtnCapsule();
            }
        }
    }

    public void Zone5OffBtnClik()
    {
        for (int i = 0; i <= Zone5.Length - 1; i++)
        {
            if (DataManager.Instance.data.modeSelect[i] == true && DataManager.Instance.data.IPAddress[i] != "0")
            {
                Zone5[i].transform.GetChild(2).GetComponent<OffButtonClik>().OffBtnCapsule();
            }
        }

        Invoke("LaterPJOffZone5", float.Parse(DataManager.Instance.data.Devel_Time));
    }

    public void LaterPJOffZone5()
    {
        for (int i = 0; i <= Zone5.Length - 1; i++)
        {
            if (DataManager.Instance.data.modeSelect[i] == false && DataManager.Instance.data.IPAddress[i] != "0")
            {
                Zone5[i].transform.GetChild(2).GetComponent<OffButtonClik>().OffBtnCapsule();
            }
        }
    }

    public void Zone6OffBtnClik()
    {
        for (int i = 0; i <= Zone6.Length - 1; i++)
        {
            if (DataManager.Instance.data.modeSelect[i] == true && DataManager.Instance.data.IPAddress[i] != "0")
            {
                Zone6[i].transform.GetChild(2).GetComponent<OffButtonClik>().OffBtnCapsule();
            }
        }

        Invoke("LaterPJOffZone6", float.Parse(DataManager.Instance.data.Devel_Time));
    }

    public void LaterPJOffZone6()
    {
        for (int i = 0; i <= Zone6.Length - 1; i++)
        {
            if (DataManager.Instance.data.modeSelect[i] == false && DataManager.Instance.data.IPAddress[i] != "0")
            {
                Zone6[i].transform.GetChild(2).GetComponent<OffButtonClik>().OffBtnCapsule();
            }
        }
    }

    public void Zone7OffBtnClik()
    {
        for (int i = 0; i <= Zone7.Length - 1; i++)
        {
            if (DataManager.Instance.data.modeSelect[i] == true && DataManager.Instance.data.IPAddress[i] != "0")
            {
                Zone7[i].transform.GetChild(2).GetComponent<OffButtonClik>().OffBtnCapsule();
            }
        }

        Invoke("LaterPJOffZone7", float.Parse(DataManager.Instance.data.Devel_Time));
    }

    public void LaterPJOffZone7()
    {
        for (int i = 0; i <= Zone7.Length - 1; i++)
        {
            if (DataManager.Instance.data.modeSelect[i] == false && DataManager.Instance.data.IPAddress[i] != "0")
            {
                Zone7[i].transform.GetChild(2).GetComponent<OffButtonClik>().OffBtnCapsule();
            }
        }
    }
}
