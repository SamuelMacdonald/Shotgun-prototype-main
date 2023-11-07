using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGunFollow : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject player;
    public float turnSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        Vector3 direction = player.transform.position - transform.position;
        float angle = Vector2.SignedAngle(Vector2.right, direction);
        Vector3 targetRotation = new Vector3(0, 0, angle);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(targetRotation), turnSpeed * Time.deltaTime);
    }
}
