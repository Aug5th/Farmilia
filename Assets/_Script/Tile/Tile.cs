using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Tile : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Transform _selectedTile;

    [SerializeField] protected SpriteRenderer spriteRenderer;

    [SerializeField] protected TileController tileController;

    [SerializeField] protected Resource placedResource;

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

    protected void SpawnResource(ResourceName resourceName,Tile tile)
    {
        if(!placedResource)
        {
            EnergyManager.Instance.ConsumeEnergy();
            ResourceSpawner.Instance.SpawnResource(resourceName, transform.position, tile);
            placedResource = GetComponentInChildren<Resource>();
        }
    }

    protected void HarvestResource()
    {
        if(!placedResource.CanHarvested)
        {
            return;
        }
        EnergyManager.Instance.ConsumeEnergy();
        Destroy(placedResource.gameObject);
        placedResource = null;
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

    public void OnPointerExit(PointerEventData eventData)
    {
        _selectedTile.gameObject.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _selectedTile.gameObject.SetActive(true);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            OnMouseClick();
        }  
    }

}
