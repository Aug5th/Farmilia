using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantSeedState : PlantState
{
    public PlantSeedState(Plant plant, PlantStateMachine plantStateMachine, Sprite sprite) : base(plant, plantStateMachine, sprite)
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
        if(plant.Date >= plant.Stats.BabyGrowthDays)
        {
            plantStateMachine.SwitchState(plant.BabyState);
        }
    }

    public override void FixedUpdateState()
    {
        base.FixedUpdateState();
    }
}
