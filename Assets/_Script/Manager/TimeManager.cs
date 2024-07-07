using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : Singleton<TimeManager>
{
    [SerializeField] private int _date;

    private void Start()
    {
        _date = 1;
        EventManager.MoveToNextDay(_date);
    }

    public int GetDay()
    {
        return _date;
    }

    public void MoveToNextDay()
    {
        _date++;
        EventManager.MoveToNextDay(_date);
        EnergyManager.Instance.RestoreAllCurrencyEnergy();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            MoveToNextDay();
        }
    }
}
