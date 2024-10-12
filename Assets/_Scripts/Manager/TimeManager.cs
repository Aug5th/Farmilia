using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : Singleton<TimeManager>
{
    [SerializeField] private int _date;

    private void Start()
    {
        _date = 1;
        EventManager.UpdateDate(_date);
    }

    public int GetDay()
    {
        return _date;
    }

    public void MoveToNextDay()
    {
        _date++;
        EventManager.MoveToNextDay();
        EventManager.UpdateDate(_date);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            MoveToNextDay();
        }
    }

}
