using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class EventManager
{
    public static event UnityAction OnMoveToNextDay;
    public static void MoveToNextDay() => OnMoveToNextDay?.Invoke();

    public static event UnityAction<int> OnDateUpdate;
    public static void UpdateDate(int currentDate) => OnDateUpdate?.Invoke(currentDate);

    public static event UnityAction<int> OnEnergyUpdate;
    public static void UpdateEnergy(int energy) => OnEnergyUpdate?.Invoke(energy);

    public static event UnityAction<int> OnGoldUpdate;
    public static void UpdateGold(int gold) => OnGoldUpdate?.Invoke(gold);
}
