using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float spawnPosX = 20f; // X position where buildings will spawn
    public float spawnRangeY = 30f;
    private float startDelay = 2f; // Delay 2 seconds before the first spawn
    private float spawnInterval = 2f; // Spawn every 1.5 seconds
    public GameObject[] buildingPrefab;
    public GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        InvokeRepeating("SpawnBuilding", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnBuilding()
    {
        if (player != null)
        {
            int randomIndex = Random.Range(0, buildingPrefab.Length);
            Vector2 spawnPos = new Vector2(spawnPosX, Random.Range( 0.41f, spawnRangeY));
            Instantiate(buildingPrefab[randomIndex], spawnPos, Quaternion.identity);
        }
    }
}
