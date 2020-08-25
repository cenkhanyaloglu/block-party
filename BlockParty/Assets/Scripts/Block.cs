using UnityEngine;

public class Block : MonoBehaviour
{   
    void Start()
    {
        // Blocks spawn faster
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / 20f;
    }

    void Update()
    {
        if (transform.position.y < -2f)
        {
            Destroy(gameObject);
        }
    }
}
