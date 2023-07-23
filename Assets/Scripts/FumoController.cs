using UnityEngine;

public class FumoController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public float gpForce = 10f;
    public Transform groundCheck;
    public LayerMask groundLayer;

    private Rigidbody rb;
    private bool isGrounded;
    private bool isDiving;
    private Transform cameraTransform;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotation;
        cameraTransform = Camera.main.transform;
    }

    private void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, 0.2f, groundLayer);

        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(moveX, 0f, moveZ);
        movement = cameraTransform.TransformDirection(movement);
        movement.y = 0f;

        movement.Normalize();
        movement *= moveSpeed;

        rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);

        if (isGrounded && Input.GetKey(KeyCode.Joystick1Button0))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        if (isGrounded && Input.GetKey(KeyCode.Joystick1Button5))
        {
            isDiving = true;
            rb.AddForce(Vector3.down * gpForce, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (isDiving && collision.gameObject.layer == groundLayer)
        {
            isDiving = false;
        }
    }
}
