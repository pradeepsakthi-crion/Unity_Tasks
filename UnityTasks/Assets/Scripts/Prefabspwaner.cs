using UnityEngine;
using TMPro;

public class PrefabSpawner : MonoBehaviour
{
    [Header("UI")]
    public TMP_Dropdown dropdown;

    [Header("Prefabs")]
    public GameObject[] prefabs;   

    [Header("Spawn Settings")]
    public Transform spawnPoint;

    private GameObject currentSpawnedPrefab;

    // Called by Spawn Button
    public void SpawnSelectedPrefab()
    {
        int index = dropdown.value;

        // Destroy existing prefab
        if (currentSpawnedPrefab != null)
        {
            Destroy(currentSpawnedPrefab);
        }

        // Spawn new prefab
        currentSpawnedPrefab = Instantiate(
            prefabs[index],
            spawnPoint.position,
            spawnPoint.rotation
        );
    }
}