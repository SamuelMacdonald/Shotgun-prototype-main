
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public int maxHealth = 100;
    public int currentHealth;
    public healthBar hb;

    private void Start()
    {
        currentHealth = maxHealth;
        hb.SetMaxHealth(maxHealth);
    }
    public void TakeDamge(int damage)
    {
        currentHealth -= damage;
        hb.SetHealth(currentHealth);
        if(currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
