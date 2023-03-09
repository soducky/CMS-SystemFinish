using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainTimer : MonoBehaviour
{
    public Text Timer_Text;
    float time_current;
    private bool isEnded;
    public GameObject timer;

    void Update()
    {
        if(isEnded) return;

        Check_Timer();
    }

    void Check_Timer()
    {
        if (0 < time_current)
        {
            time_current -= Time.deltaTime;
            Timer_Text.text = $"{time_current:N0}";
        }
        else if (!isEnded)
        {
            End_Timer();
        }
    }

    private void End_Timer()
    {
        time_current = 0;
        Timer_Text.text = $"{time_current:N0}";
        isEnded = true;
        timer.SetActive(false);
    }

    public void Reset_Timer()
    {
        timer.SetActive(true);
        time_current = float.Parse(DataManager.Instance.data.Devel_Time);
        Timer_Text.text = $"{time_current:N0}";
        isEnded= false;
    }
}
