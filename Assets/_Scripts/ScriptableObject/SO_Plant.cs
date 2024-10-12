using System;
using UnityEngine;

[CreateAssetMenu(fileName = "New Plant", menuName = "Scriptable Objects/Plant")]
public class SO_Plant : ScriptableObject
{
    [SerializeField] private PlantStats _stats;
    public PlantStats Stats => _stats; 
    public PlantType PlantType;
    public Plant Prefab;
}

[Serializable]
public struct PlantStats
{
    public int BabyGrowthDays;
    public int AdultGrowthDays;   
}

[Serializable]
public enum PlantType
{
    None,
    Carrot,
    Rice
}





