using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyManager : Singleton<EnergyManager>
{
    [SerializeField] private int _currentEnergy;
    [SerializeField] private int _maxEnergy;
}
