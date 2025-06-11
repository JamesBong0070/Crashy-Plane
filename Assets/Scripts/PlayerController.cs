using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rbPlayer;
    Vector2 flapForce = new Vector2(0, 15f);
    InputAction flapAction;
    bool flapRequested = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        flapAction = InputSystem.actions.FindAction("Jump");
        rbPlayer = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (flapAction.triggered)
        {
            flapRequested = true;
        }
    }

    void FixedUpdate()
    {
        if (flapRequested)
        {
            rbPlayer.AddForce(flapForce, ForceMode2D.Impulse);
            Debug.Log("Trying to flap");
            flapRequested = false; // Reset the flap request after applying the force
        }
    }
}
