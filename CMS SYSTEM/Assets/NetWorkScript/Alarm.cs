using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Alarm : MonoBehaviour
{
    private bool isAlarmSet = false;
    private DateTime _alarmTime = DateTime.Today;
  
    void Start()
    {
        SetAlarm();
    }

    void Update()
    {
        if(isAlarmSet && DateTime.Now > _alarmTime)
        {
            Debug.Log("¾Ë¶÷");
            isAlarmSet = false; 
        }
    }

    public void SetAlarm()
    {
        int hours;

        if (DataManager.Instance.data.Open_DropDown == 0)
        {
            hours = int.Parse(DataManager.Instance.data.Open_Hour);
        }
        else
        {
            hours = int.Parse(DataManager.Instance.data.Open_Hour) + 12;
        }

        TimeSpan ts = TimeSpan.Parse($"{hours}:{ DataManager.Instance.data.Open_Minute}:{ DataManager.Instance.data.Open_Second}");
        _alarmTime += ts;
         
        if(DateTime.Now> _alarmTime )
        {
            _alarmTime= _alarmTime.AddDays(1);
        }
 
        isAlarmSet= true;

    }
}
