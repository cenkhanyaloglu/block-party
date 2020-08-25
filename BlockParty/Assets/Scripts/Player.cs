using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float mapWidth;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;
        Vector2 newPosition = rb.position + Vector2.right * x;
        newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);
        rb.MovePosition(newPosition);
    }
    void OnCollisionEnter2D()
    {
        FindObjectOfType<GameManager>().EndGame();
    }
}
