using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgunprototype : MonoBehaviour
{
    // Start is called before the first frame update
    public float turnSpeed;
    public int bullet;
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePosition - transform.position;
        float angle = Vector2.SignedAngle(Vector2.right, direction);
        Vector3 targetRotation = new Vector3(0, 0, angle);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(targetRotation), turnSpeed * Time.deltaTime);
        if (Input.GetMouseButtonDown(0) && bullet >= 1)
        {
            bullet--;
        }
        if (Input.GetKeyDown("r") && bullet == 0)
        {
            bullet++;
            bullet++;
        }

    }
}
