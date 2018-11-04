using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public float jumpForce = 10f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update ()
    {
        if (GameManager.GameIsRunning && rb.bodyType != RigidbodyType2D.Dynamic)
            rb.bodyType = RigidbodyType2D.Dynamic;

        if (GameManager.GameIsRunning && (Input.GetButtonDown("Jump") || Input.GetButtonDown("Fire1")))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "ScorePoint")
        {
            GameManager.Score++;
            col.enabled = false;
        } else
        {
            GameManager.GameIsRunning = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
