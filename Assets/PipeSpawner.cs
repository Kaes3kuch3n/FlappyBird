using UnityEngine;

public class PipeSpawner : MonoBehaviour {

    public float spawnDelay = 3f;
    public float minYSpawn = -5f;
    public float maxYSpawn = 5f;
    public GameObject pipePrefab;

    private float nextTimeToSpawn = 0f;

    private void Update()
    {
        if (GameManager.GameIsRunning && nextTimeToSpawn < Time.time)
        {
            SpawnPipe();
            nextTimeToSpawn = Time.time + spawnDelay;
        }
    }

    private void SpawnPipe()
    {
        float randomSpawnPositionY = Random.Range(minYSpawn, maxYSpawn);
        Instantiate(pipePrefab, new Vector2(transform.position.x, randomSpawnPositionY), transform.rotation);
    }
}
