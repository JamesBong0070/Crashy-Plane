using UnityEngine;

public class scrollingGrass : MonoBehaviour
{
    public GameObject player;
    public float speed;

    [SerializeField]
    private Renderer grassRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            grassRenderer.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
            return;
        }
    }
}
