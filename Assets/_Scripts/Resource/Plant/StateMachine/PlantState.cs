using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantState
{
    protected Plant plant;
    protected PlantStateMachine plantStateMachine;
    protected Sprite sprite;

    public PlantState(Plant plant, PlantStateMachine plantStateMachine, Sprite sprite)
    {
        this.plant = plant;
        this.plantStateMachine = plantStateMachine;
        this.sprite = sprite;
    }

    public virtual void EnterState()
    {
        plant.ResetDay();
        if(sprite)
        {
            plant.SetSprite(sprite);
        }
    }
    public virtual void ExitState(){}
    public virtual void UpdateState(){}
    public virtual void FixedUpdateState(){}
}
