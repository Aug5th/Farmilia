using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Transform _selectedTile;

    [SerializeField] protected SpriteRenderer spriteRenderer;

    [SerializeField] protected TileController tileController;

    protected List<Vector2> aroundTilesPosition;



    private void Awake()
    {
        _selectedTile = transform.Find("Selected");
        spriteRenderer = GetComponent<SpriteRenderer>();
        tileController = GetComponentInParent<TileController>();
        aroundTilesPosition = new List<Vector2>();
    }

    private void Start()
    {
        InitializeTile();
    }

    protected virtual void InitializeTile()
    {
        GetAroundTilesPosition();
    }

    protected virtual void OnMouseClick() { }
    
    protected void SetSelectedTile(string tileName)
    {
        _selectedTile = transform.Find(tileName);
    }

    protected void GetAroundTilesPosition()
    {
        for (float x = transform.position.x - 1; x <= transform.position.x + 1; x++)
        {
            for (float y = transform.position.y - 1; y <= transform.position.y + 1; y++)
            {
                if (x == transform.position.x && y == transform.position.y)
                {
                    continue;
                }
                aroundTilesPosition.Add(new Vector2(x, y));
            }
        }
    }

    protected void SpawnResource()
    {
        ResourceSpawner.Instance.SpawnCarrot(transform.position);
    }

    protected bool CheckTileAround(TileType tile)
    {
        if (aroundTilesPosition != null)
        {
            foreach (var pos in aroundTilesPosition)
            {
                if (GridManager.Instance.GetTileAtPosition(pos).TileType == tile)
                {
                    return true;
                }
            }
        }
        return false;
    }

    private void OnMouseDown()
    {
        OnMouseClick();
    }

    private void OnMouseEnter()
    {
        _selectedTile.gameObject.SetActive(true);
    }

    private void OnMouseExit()
    {
        _selectedTile.gameObject.SetActive(false);
    }
}
