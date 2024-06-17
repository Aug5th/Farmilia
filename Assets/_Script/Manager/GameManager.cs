using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] private SO_Resource _selectedResource;
    public SO_Resource SelectedResouce => _selectedResource;
    
    public void SetSelectedResource(SO_Resource resource)
    {
        _selectedResource = resource;
    }
}
