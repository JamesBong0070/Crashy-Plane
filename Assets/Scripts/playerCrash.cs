using UnityEngine;

public class playerCrash : MonoBehaviour
{
    public static playerCrash instance;
    public bool hasCrashed = false;
    Rigidbody2D rbPlayer;

    void Awake()
    {
        instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Obstacle"))
        {
            // Stop the player movement
            Destroy(gameObject);
            hasCrashed = true;

            // Optionally, you can add more logic here, like playing a sound or triggering an animation
            Debug.Log("Player has crashed into an obstacle!");
        }
    }
}
