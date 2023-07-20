using UnityEngine;

public class FumoPrefabController : MonoBehaviour
{
    public Transform groundCheck;
    public LayerMask groundLayer;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotation;
    }
}
