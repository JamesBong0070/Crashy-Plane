using UnityEngine;

public class BuildingScroller : MonoBehaviour
{
    public int scrollSpeed = 1; // Speed of the scrolling effect

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * scrollSpeed * Time.deltaTime); //PROBLEM: Goes as fast as the frame rate
    }
}
