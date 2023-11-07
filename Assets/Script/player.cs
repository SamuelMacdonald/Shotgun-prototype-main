using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public float ve;
    public int bullet;
   public float maxSpeed;
   
    
    
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);


       
        if(rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
        }
        
        
        if (Input.GetMouseButtonDown(0) && bullet >= 1 )
        {
            rb.velocity = -mousePosition * ve;
            bullet--;
            
        }
       if(Input.GetMouseButtonDown(0) && bullet == 0 )
        {
           maxSpeed = maxSpeed + 10;
        }
        if (Input.GetKeyDown("r") && bullet == 0)
        {
            bullet++;
            bullet++;
            maxSpeed = 20;
        }
        
      
    }
    
}
