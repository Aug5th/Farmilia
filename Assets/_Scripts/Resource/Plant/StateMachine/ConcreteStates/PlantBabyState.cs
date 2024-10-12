using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantBabyState : PlantState
{
    public PlantBabyState(Plant plant, PlantStateMachine plantStateMachine, Sprite sprite) : base(plant, plantStateMachine, sprite)
    {
    }

    public override void EnterState()
    {
        base.EnterState();
    }

    public override void ExitState()
    {
        base.ExitState();
    }

    public override void UpdateState()
    {
        base.UpdateState();
        if(plant.Date >= plant.Stats.AdultGrowthDays)
        {
            plantStateMachine.SwitchState(plant.AdultState);
        }
    }

    public override void FixedUpdateState()
    {
        base.FixedUpdateState();
    }
}
