using UnityEngine;

public class PlantSpawner : Singleton<PlantSpawner>
{
    [SerializeField] protected Transform _holder;
    public void SpawnPlant(PlantType plantType, Vector3 position, Tile tile)
    {
        var plantSO = ResourceSystem.Instance.GetPlantByType(plantType);
        var plant = Instantiate(plantSO.Prefab, position, Quaternion.identity);
        plant.SetStats(plantSO.Stats);
        plant.transform.SetParent(tile.transform);
    }
}
