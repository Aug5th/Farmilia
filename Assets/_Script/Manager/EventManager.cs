using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class EventManager
{
    public static event UnityAction<int> OnMoveToNextDay;
    public static void MoveToNextDay(int date) => OnMoveToNextDay?.Invoke(date);
}
