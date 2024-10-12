using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyTile : Tile
{
    private void Start()
    {
        SetSelectedTile("Grass");
    }

    protected override void OnMouseClick() 
    {
        tileController.SwitchTile(TileType.Grass);
    }

}
