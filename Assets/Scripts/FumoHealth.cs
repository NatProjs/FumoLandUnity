using UnityEngine;
using UnityEngine.SceneManagement;

public class FumoHealth : MonoBehaviour
{
    public int maxHealth = 75;
    public int currentHealth;
    public string Scene;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void Heal(int healAmount)
    {
        currentHealth += healAmount;
        currentHealth = Mathf.Min(currentHealth, maxHealth);
    }

    void Die()
    {
        Debug.Log("You killed the fumo :c");
        SceneManager.LoadScene(Scene);
    }
}
