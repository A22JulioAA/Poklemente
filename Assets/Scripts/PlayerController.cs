using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float speed = 5.0f;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        if (horizontalInput != 0) {
            transform.localScale = new Vector3(Mathf.Sign(horizontalInput), 1, 1);
        }

    }

    void FixedUpdate()
    {
        float targetX = horizontalInput * speed;
        float targetY = verticalInput * speed;

        rb.linearVelocity = new Vector2(Mathf.Lerp(rb.linearVelocity.x, targetX, 0.1f), 
                              Mathf.Lerp(rb.linearVelocity.y, targetY, 0.1f));
    }
}
