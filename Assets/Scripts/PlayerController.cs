using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float jumpForce = 10f;
    [SerializeField] private GameObject _menu;

    private Rigidbody2D rb;

    private int _score = 0;

    public int Score {
        get { return _score; }
    }

    public bool IsAlive {
        get { return gameObject.activeSelf; }
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        gameObject.SetActive(false); // Initially deactivate the player
    }

    void Update()
    {
        if (Input.GetMouseButton(0)) { 
            rb.linearVelocityY = jumpForce; // Set the vertical velocity to jumpForce
        }

        transform.rotation = Quaternion.Euler(0, 0, rb.linearVelocity.y); // Rotate the player based on vertical velocity
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.SetActive(false); // Deactivate the obstacle on collision
        _menu.SetActive(true); // Show the menu when the player collides with an obstacle
        _score = 0; // Reset the score when the player collides with an obstacle
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _score += 1; // Increment the score when the player passes through a trigger collider
    }
}
