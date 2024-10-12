using System;
using UnityEngine;

public class TileController : MonoBehaviour
{
    [SerializeField] private TileType _tileType;
    public void SetTileType(TileType tileType) => _tileType = tileType;
    public TileType TileType => _tileType;

    [SerializeField] private Tile _emptyTile, _grassTile, _groundTile, _moistGroundTile, _waterTile;

    [SerializeField] private Tile _currentTile;
    public Tile CurrentTile => _currentTile;

    private void Start()
    {
        DisbleAllTiles();
        UpdateTile();
    }

    private void DisbleAllTiles()
    {
        _emptyTile.gameObject.SetActive(false);
        _grassTile.gameObject.SetActive(false);
        _groundTile.gameObject.SetActive(false);
        _moistGroundTile.gameObject.SetActive(false);
        _waterTile.gameObject.SetActive(false);
    }
    private void UpdateTile()
    {
        DisbleAllTiles();
        switch (_tileType)
        {
            case TileType.Empty:
                _emptyTile.gameObject.SetActive(true);
                _currentTile = _emptyTile;
                break;
            case TileType.Grass:
                _grassTile.gameObject.SetActive(true);
                _currentTile = _grassTile;
                break;
            case TileType.Ground:
                _groundTile.gameObject.SetActive(true);
                _currentTile = _groundTile;
                break;
            case TileType.MoistGround:
                _moistGroundTile.gameObject.SetActive(true);
                _currentTile = _moistGroundTile;
                break;
            case TileType.Water:
                _waterTile.gameObject.SetActive(true);
                _currentTile = _waterTile;
                break;
            default:
                break;
        }
    }

    public void SwitchTile(TileType type)
    {
        _tileType = type;
        UpdateTile();
    }
}

[Serializable]
public enum TileType
{
    Empty,
    Grass,
    Ground,
    MoistGround,
    Water
}