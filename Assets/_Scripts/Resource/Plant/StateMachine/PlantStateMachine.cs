using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantStateMachine
{
    private PlantState _currentState;
    public PlantState CurrentState => _currentState;

    public void Initialize(PlantState startState)
    {
        _currentState = startState;
        _currentState.EnterState();
    }

    public void SwitchState(PlantState newState)
    {
        _currentState.ExitState();
        _currentState = newState;
        _currentState.EnterState();
    }
}
