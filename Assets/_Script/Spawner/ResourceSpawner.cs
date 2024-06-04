using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceSpawner : Singleton<ResourceSpawner>
{
    [SerializeField] protected Transform _resourceHolder;
    [SerializeField] private Resource _carrot;


    public void SpawnCarrot(Vector3 position)
    {
        var resource = Instantiate(_carrot, position, Quaternion.identity);
        resource.transform.SetParent(_resourceHolder);
    }
}
