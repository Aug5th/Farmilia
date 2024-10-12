using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassTile : Tile
{
    protected override void OnMouseClick()
    {
        tileController.SwitchTile(TileType.Ground);
    }

    private void Start()
    {
        SetSelectedTile("Ground");
    }
}
