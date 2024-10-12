using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ResourceSystem : Singleton<ResourceSystem>
{
    [Header("Plants")]
    [SerializeField] private List<SO_Plant> _plants;
    public List<SO_Plant> Plants => _plants;
    [SerializeField] private Dictionary<PlantType, SO_Plant> _plantDict;


    protected override void Awake()
    {
        base.Awake();
        AssembleResources();
    }

    private void AssembleResources()
    {
        LoadPlants();
    }

    private void LoadPlants()
    {
        _plants = Resources.LoadAll<SO_Plant>("Plants").ToList();
        _plantDict = _plants.ToDictionary(p => p.PlantType, p => p);
    }

    public SO_Plant GetPlantByType(PlantType type) => _plantDict[type];
}
