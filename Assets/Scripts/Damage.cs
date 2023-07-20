using UnityEngine;

public class Damage : MonoBehaviour
{
    public int damageAmount = 25;

    void OnTriggerEnter(Collider other)
    {
        FumoHealth healthComponent = other.GetComponent<FumoHealth>();

        if (healthComponent != null)
        {
            healthComponent.TakeDamage(damageAmount);
        }
    }
}
