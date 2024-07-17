using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform[] spawnPoints;
    public float spawnInterval = 2f;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnInterval, spawnInterval);
    }

    void SpawnEnemy()
    {
        int spawnIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(enemyPrefab, spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
    }
}
