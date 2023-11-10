using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerbullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 20f;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = transform.right * speed;
        rb = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "enemy" && collider.gameObject.tag == "ground")
        {
            Destroy(gameObject);
            var healthComponent = collider.GetComponent<enemyHealth>();
            if (healthComponent != null)
            {
                healthComponent.TakeDamge(20);

            }

        }
    }
}
