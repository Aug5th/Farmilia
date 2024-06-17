using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyManager : Singleton<EnergyManager>
{
    public int CurrentEnergy { get; private set; }
    public int MaxEnergy { get; private set; } = 5;

    protected override void Awake()
    {
        base.Awake();
        CurrentEnergy = MaxEnergy;
        OnEventEnergyUpdate();
    }

    public void RestoreAllCurrencyEnergy()
    {
        CurrentEnergy = MaxEnergy;
        OnEventEnergyUpdate();
    }

    public void RestoreEnergy(int energy)
    {
        CurrentEnergy += energy;
        OnEventEnergyUpdate();
    }

    public void ConsumeEnergy(int energy = 1)
    {
        CurrentEnergy -= energy;
        OnEventEnergyUpdate();
    }

    public bool OutOfEnergy()
    {
        return CurrentEnergy <= 0;
    }

    private void OnEventEnergyUpdate()
    {
        EventManager.UpdateEnergy(CurrentEnergy);
    }

}
