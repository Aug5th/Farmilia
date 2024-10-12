using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : Tile
{
    private void Start()
    {
        InitializeTile();
    }

    protected override void InitializeTile()
    {
        base.InitializeTile();
        if(CheckTileAround(TileType.Water))
        {
            tileController.SwitchTile(TileType.MoistGround);
        }
    }

    protected override void OnMouseClick()
    {
        tileController.SwitchTile(TileType.MoistGround);
    }
}
