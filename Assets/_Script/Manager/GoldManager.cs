using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldManager : Singleton<GoldManager>
{
    public int Gold { get; private set; } = 0;

    private void Start()
    {
        OnEventGoldUpdate();
    }

    public void AddGold(int amount)
    {
        Gold += amount;
        OnEventGoldUpdate();
    }

    public void SpendGold(int amount)
    {
        Gold -= amount;
        OnEventGoldUpdate();
    }

    private void OnEventGoldUpdate()
    {
        EventManager.UpdateGold(Gold);
    }
}
