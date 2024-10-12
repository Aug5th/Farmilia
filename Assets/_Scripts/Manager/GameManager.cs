using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] private SO_Plant _selectedResource;
    public SO_Plant SelectedResource => _selectedResource;
    
    public void SetSelectedResource(SO_Plant resource)
    {
        _selectedResource = resource;
    }
}
