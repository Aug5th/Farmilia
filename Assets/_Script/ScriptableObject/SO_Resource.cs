using System;
using UnityEngine;

[CreateAssetMenu(fileName = "New Resource", menuName = "Scriptable Objects/Resources")]
public class SO_Resource : ScriptableObject
{
    public ResourceType ResourceType;
    public ResourceName ResourceName;
    public Resource Prefab;
    public int GrownDays;
}

[Serializable]
public enum ResourceName
{
    None,
    Carrot,
    Rice,
    Grass
}

[Serializable]
public enum ResourceType
{
    Plant,
    Water,
    Animal
}


