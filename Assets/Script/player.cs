using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public float ve;
    public int bullet;
   public float maxSpeed;
    public Vector3 screenPosition;
    public Vector3 worldPosition;
    BoxCollider2D bc;
    [SerializeField] private LayerMask lm;
    Animator an;
    
    
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
      bc = GetComponent<BoxCollider2D>();
        an = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    { 
        
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 relativeMousePosition = (Vector3)rb.position - mousePosition;




        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
        }
        
        
        if (Input.GetMouseButtonDown(0) && bullet >= 1 )
        {
            rb.velocity = relativeMousePosition * ve;
            bullet--;
            
        }
        if (Input.GetMouseButtonDown(0) && bullet == 1)
        {
            maxSpeed = maxSpeed * 1.5f;
        }
        if (Input.GetMouseButtonDown(0) && bullet == 0 )
        {
            ve = ve + 2;
            
        }
        if (IsGrounded() && Input.GetKeyDown("r") && bullet == 0)
        {
            bullet = 3;
            maxSpeed = 20;
            ve = 10;
        }
        if (IsGrounded() == false)
        {
            an.SetBool("air", true);
        }
        else
        {
            an.SetBool("air", false);
        }
        
        
      
    }
   private bool IsGrounded()
    {
        float extraHeightText = 5f;
        RaycastHit2D raycastHit = Physics2D.Raycast(bc.bounds.center, Vector2.down, bc.bounds.extents.y + extraHeightText, lm);
        Color rayColor;
        if(raycastHit.collider != null)
        {
            rayColor = Color.green;
        }
        else
        {
            rayColor = Color.red;
        }
        Debug.DrawRay(bc.bounds.center, Vector2.down * (bc.bounds.extents.y));
        Debug.Log(raycastHit.collider);
        return raycastHit.collider != null;
    }

}
