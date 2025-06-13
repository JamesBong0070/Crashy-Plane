using UnityEngine;

public class BuildingScroller : MonoBehaviour
{
    public float scrollSpeed = .5f; // Speed of the scrolling effect
    public GameObject player;
    private bool hasScored = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindWithTag("Player");        
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasScored && transform.position.x < -2f)
        {
            Debug.Log("Building crossed score zone");
            ScoreManager.instance.AddScore();
            hasScored = true;
        }
        if (player != null)
        {
            transform.Translate(Vector2.left * scrollSpeed * Time.deltaTime); //PROBLEM: Goes as fast as the frame rate
            return;
        }
    }
}
