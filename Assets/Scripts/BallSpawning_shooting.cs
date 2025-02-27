using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BallSpawning_shooting : MonoBehaviour
{
    public GameObject Ball;
    public GameObject Point;
    private Rigidbody rb;
    public float BallSpeed = 20f;

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            ShootBall();
        }
    }

    void ShootBall()
    {
        GameObject newBall = Instantiate(Ball, Point.transform.position, Quaternion.identity);
        
        Rigidbody rb = newBall.GetComponent<Rigidbody>();
        rb.linearVelocity = Point.transform.forward * BallSpeed;
    }   
}