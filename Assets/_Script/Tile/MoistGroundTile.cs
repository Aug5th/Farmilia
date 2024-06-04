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
        //SpawnResource
        SpawnResource();
        //tileController.SwitchTile(TileType.Water);

    }
    
}
