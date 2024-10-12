using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantAdultState : PlantState
{
    public PlantAdultState(Plant plant, PlantStateMachine plantStateMachine, Sprite sprite) : base(plant, plantStateMachine, sprite)
    {
    }

    public override void EnterState()
    {
        base.EnterState();
        plant.SetCanHarvest();
    }

    public override void ExitState()
    {
        base.ExitState();
    }

    public override void UpdateState()
    {
        base.UpdateState();
    }

    public override void FixedUpdateState()
    {
        base.FixedUpdateState();
    }
}
