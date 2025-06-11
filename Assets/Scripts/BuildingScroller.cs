using UnityEngine;

public class BuildingScroller : MonoBehaviour
{
    public float scrollSpeed = .5f; // Speed of the scrolling effect
    public GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindWithTag("Player");        
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            transform.Translate(Vector2.left * scrollSpeed * Time.deltaTime); //PROBLEM: Goes as fast as the frame rate
            return;
        }
    }
}
