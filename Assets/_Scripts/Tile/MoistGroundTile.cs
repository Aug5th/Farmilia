using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoistGroundTile : Tile
{
    
    
    private void Start()
    {
        SetSelectedTile("Selected");
        GetAroundTilesPosition();
    }

    protected override void OnMouseClick()
    {
        if(!GameManager.Instance.SelectedResource || EnergyManager.Instance.OutOfEnergy())
        {
            return;
        }

        if (placedResource)
        {
            HarvestResource();
        }
        else
        {
            SpawnResource(GameManager.Instance.SelectedResource.PlantType, this);
        }
    }
    
}
