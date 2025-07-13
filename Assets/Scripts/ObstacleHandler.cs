using UnityEngine;

public class ObstacleHandler : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float destroyDistance = -7f; // Distance at which the obstacle will be destroyed

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        if (transform.position.x <= destroyDistance) {
            Destroy(gameObject); // Destroy the obstacle when it moves past the destroy distance
        }
    }
}
