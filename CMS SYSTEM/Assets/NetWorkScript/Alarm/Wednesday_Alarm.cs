using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Wednesday_Alarm : MonoBehaviour
{
    private bool OpenAlarmSet;
    private bool CloseAlarmSet;

    int toDay;
    int goalDay;

    TimeSpan ts;
    DateTime _alarmTime = DateTime.Today; // Open

    int Close_toDay;
    int Close_goalDay;

    TimeSpan Close_ts;
    DateTime Close_alarmTime = DateTime.Today; //Close

    private IEnumerator coroutine; // 코루틴
    private bool isCoroutine = false; // 60분짜리 코루틴 update문에 사용 


    void Start()
    {
        OpenSetAlarm();
        CloseSetAlarm();
    }

    void Update()
    {
        if (DataManager.Instance.data.Alarm_weekday[3] == true && OpenAlarmSet && DateTime.Now > _alarmTime)
        {
            GameObject.FindGameObjectWithTag("Server").GetComponent<Client>().AllOn();
            OpenAlarmSet = false;
        }

        if (DataManager.Instance.data.Alarm_weekday[3] == true && CloseAlarmSet && DateTime.Now > Close_alarmTime)
        {
            GameObject.FindGameObjectWithTag("Server").GetComponent<Client>().AllOff();
            CloseAlarmSet = false;
        }

        if (!isCoroutine)
        {
            coroutine = countTime(3600f); // 3600초 , 60분마다 반복
            StartCoroutine(coroutine);
        }
    }
    IEnumerator countTime(float delayTime)
    {
        isCoroutine = true;
        yield return new WaitForSeconds(delayTime);

        OpenSetAlarm();
        CloseSetAlarm();
        isCoroutine = false;
    }
    public void OpenSetAlarm()
    {
        if (DataManager.Instance.data.Alarm_weekday[3] == true)
        {
            _alarmTime = DateTime.Today;

            int hours;

            if (DataManager.Instance.data.Open_DropDown == 0)
            {
                hours = int.Parse(DataManager.Instance.data.Open_Hour);
            }
            else
            {
                hours = int.Parse(DataManager.Instance.data.Open_Hour) + 12;
            }

            ts = TimeSpan.Parse($"{hours}:{DataManager.Instance.data.Open_Minute}:{DataManager.Instance.data.Open_Second}");

            toDay = Convert.ToInt32(_alarmTime.DayOfWeek);
            goalDay = Convert.ToInt32(DayOfWeek.Wednesday);

            _alarmTime += ts;

            if (goalDay > toDay)
            {
                _alarmTime = _alarmTime.AddDays(goalDay - toDay);
                Debug.Log(_alarmTime);
            }

            else if (goalDay == toDay)
            {
                if (DateTime.Now > _alarmTime)
                {
                    _alarmTime = _alarmTime.AddDays(7);
                    Debug.Log(_alarmTime);
                }
            }

            else if (goalDay < toDay)
            {
                _alarmTime = _alarmTime.AddDays(goalDay + 7 - toDay);
                Debug.Log(_alarmTime);
            }

            OpenAlarmSet = true;
            Debug.Log(_alarmTime);
        }
    }

    public void CloseSetAlarm()
    {
        if (DataManager.Instance.data.Alarm_weekday[3] == true)
        {
            Close_alarmTime = DateTime.Today;

            int hours;

            if (DataManager.Instance.data.Close_DropDown == 0)
            {
                hours = int.Parse(DataManager.Instance.data.Close_Hour);
            }
            else
            {
                hours = int.Parse(DataManager.Instance.data.Close_Hour) + 12;
            }

            Close_ts = TimeSpan.Parse($"{hours}:{DataManager.Instance.data.Close_Minute}:{DataManager.Instance.data.Close_Second}");

            Close_toDay = Convert.ToInt32(Close_alarmTime.DayOfWeek);
            Close_goalDay = Convert.ToInt32(DayOfWeek.Wednesday);

            Close_alarmTime += Close_ts;

            if (Close_goalDay > Close_toDay)
            {
                Close_alarmTime = Close_alarmTime.AddDays(Close_goalDay - Close_toDay);
                Debug.Log(Close_alarmTime);
            }

            else if (Close_goalDay == Close_toDay)
            {
                if (DateTime.Now > Close_alarmTime)
                {
                    Close_alarmTime = Close_alarmTime.AddDays(7);
                    Debug.Log(Close_alarmTime);
                }
            }

            else if (Close_goalDay < Close_toDay)
            {
                Close_alarmTime = Close_alarmTime.AddDays(Close_goalDay + 7 - Close_toDay);
                Debug.Log(Close_alarmTime);
            }

            CloseAlarmSet = true;
            Debug.Log(Close_alarmTime);
        }
    }
}
