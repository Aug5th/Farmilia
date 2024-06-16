using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ResourceSystem : Singleton<ResourceSystem>
{
    [Header("Resources")]
    [SerializeField] private List<SO_Resource> _resources;
    public List<SO_Resource> Resource => _resources;
    [SerializeField] private Dictionary<ResourceName, SO_Resource> _resourceDict;


    protected override void Awake()
    {
        base.Awake();
        AssembleResources();
    }

    private void AssembleResources()
    {
        LoadResources();
    }

    private void LoadResources()
    {
        _resources = Resources.LoadAll<SO_Resource>("Resources").ToList();
        _resourceDict = _resources.ToDictionary(r => r.ResourceName, r => r);
    }
    public void GetResourceName(ResourceName name)
    {
        Debug.Log(name);
    }

    public SO_Resource GetResourceByName(ResourceName name) => _resourceDict[name];
}
