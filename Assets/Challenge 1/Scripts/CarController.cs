using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 15f;
    public float turnSpeed = 80f;

    private Rigidbody rb;
    private float forward;
    private float turn;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        forward = Input.GetAxis("Vertical");
        turn = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        Vector3 velocity = transform.forward * forward * speed;
        velocity.y = rb.linearVelocity.y;
        rb.linearVelocity = velocity;

        rb.MoveRotation(rb.rotation * Quaternion.Euler(
            Of,turnSpeed * Time.fixedDeltaTime, Of));
    }
}
