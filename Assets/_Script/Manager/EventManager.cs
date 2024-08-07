using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class EventManager
{
    public static event UnityAction<int> OnMoveToNextDay;
    public static void MoveToNextDay(int date) => OnMoveToNextDay?.Invoke(date);

    public static event UnityAction<int> OnEnergyUpdate;
    public static void UpdateEnergy(int energy) => OnEnergyUpdate?.Invoke(energy);

    public static event UnityAction<int> OnGoldUpdate;
    public static void UpdateGold(int gold) => OnGoldUpdate?.Invoke(gold);
}
