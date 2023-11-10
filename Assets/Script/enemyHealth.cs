using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public int maxHealth = 100;
    public int currentHealth;
    public healthBar hb;
    public int Respawn;

    private void Start()
    {
        currentHealth = maxHealth;
        hb.SetMaxHealth(maxHealth);
    }
    public void TakeDamge(int damage)
    {
        currentHealth -= damage;
        hb.SetHealth(currentHealth);
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene(Respawn);
        }
    }
}
