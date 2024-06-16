using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceSpawner : Singleton<ResourceSpawner>
{
    [SerializeField] protected Transform _resourceHolder;
    public void SpawnResource(ResourceName resourceName, Vector3 position, Tile tile)
    {
        var resourceSO = ResourceSystem.Instance.GetResourceByName(resourceName);
        var resource = Instantiate(resourceSO.Prefab, position, Quaternion.identity);
        resource.transform.SetParent(tile.transform);
        resource.SetGrownDays(resourceSO.GrownDays);
    }
}
