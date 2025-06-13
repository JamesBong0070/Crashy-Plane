using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Left boundary for the object
    float leftBound = -30f;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < leftBound)
        {
            // Destroy the game object if it goes out of bounds
            Destroy(gameObject);
        }
    }
}
