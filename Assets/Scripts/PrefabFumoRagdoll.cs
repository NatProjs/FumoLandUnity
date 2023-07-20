using UnityEngine;

public class PrefabFumoRagdoll : MonoBehaviour
{
    private Rigidbody[] rigidbodies;
    private Collider[] colliders;
    private Animator animator;

    private void Awake()
    {
        rigidbodies = GetComponentsInChildren<Rigidbody>();
        colliders = GetComponentsInChildren<Collider>();
        animator = GetComponent<Animator>();

        SetRagdollEnabled(true);
    }

    private void SetRagdollEnabled(bool enabled)
    {
        foreach (var rb in rigidbodies)
        {
            rb.isKinematic = !enabled;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }

        foreach (var collider in colliders)
        {
            collider.enabled = enabled;
        }

        animator.enabled = !enabled;
    }
}
