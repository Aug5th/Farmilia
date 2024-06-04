using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTile : Tile
{

    protected override void InitializeTile()
    {
        base.InitializeTile();
        WaterAroundGrounds();
    }
    private void WaterAroundGrounds()
    {
        foreach (var pos in aroundTilesPosition)
        {
            var tileHolder = GridManager.Instance.GetTileAtPosition(pos);
            if (tileHolder.TileType == TileType.Ground)
            {
                tileHolder.SetTileType(TileType.MoistGround);
                tileHolder.SwitchTile(TileType.MoistGround);
            }
        }
    }
}
