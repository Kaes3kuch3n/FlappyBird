using UnityEngine;

public class Pipe : MonoBehaviour {

    public float speed = 1f;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (GameManager.GameIsRunning)
            rb.MovePosition(rb.position + Vector2.left * speed * Time.fixedDeltaTime);
    }
}
