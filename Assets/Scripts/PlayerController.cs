using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float jumpForce = 10f;

    private Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButton(0)) { 
            rb.linearVelocityY = jumpForce; // Set the vertical velocity to jumpForce
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.SetActive(false); // Deactivate the obstacle on collision
    }
}
