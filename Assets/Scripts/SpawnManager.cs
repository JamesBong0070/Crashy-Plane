using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float spawnPosX = 20f;
    public float spawnRangeY = 6f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 spawnPos = new Vector2(spawnPosX, Random.Range(-spawnRangeY, spawnRangeY));
        
    }
}
