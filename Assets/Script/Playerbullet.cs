using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerbullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 20;
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
        enemyHealth en = collider.GetComponent<enemyHealth>();
        if(en != null)
        {
            en.TakeDamge(damage);
        }
        Destroy(gameObject);
       
    }
}
