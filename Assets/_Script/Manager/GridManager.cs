using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : Singleton<GridManager>
{
    [SerializeField] private int _width, _height;
    [SerializeField] private TileController _tileHolder;
    [SerializeField] private Transform _camera;
    [SerializeField] private Transform _farm;

    private Dictionary<Vector2, TileController> _tiles;

    private void Start()
    {
        GenerateGrid();
    }

    private void GenerateGrid()
    {
        _tiles = new Dictionary<Vector2, TileController>();
        for (int x = 0; x < _width; x++)
        {
            for (int y = 0; y < _height; y++)
            {

                if (Helpers.InRange(x, _width / 2 - 1, _width / 2 + 1) && Helpers.InRange(y, _height / 2 - 2, _height / 2))
                {
                    GenerateTile(TileType.Grass, x, y);

                }
                else
                {
                    GenerateTile(TileType.Empty, x, y);
                }
            }
        }

        _camera.position = new Vector3((float)_width / 2 - 0.5f, (float)_height / 2 - 0.5f, -10f);
    }

    private void GenerateTile(TileType tileType, int x, int y)
    {
        var tile = Instantiate(_tileHolder, new Vector3(x, y), Quaternion.identity);
        tile.SetTileType(tileType);
        tile.name = $"Tile {x} {y}";
        tile.transform.SetParent(_farm);
        _tiles[new Vector2(x, y)] = tile;
    }

    public TileController GetTileAtPosition(Vector2 position)
    {
        if (_tiles.TryGetValue(position, out var tile))
        {
            return tile;
        }
        return null;
    }
}
