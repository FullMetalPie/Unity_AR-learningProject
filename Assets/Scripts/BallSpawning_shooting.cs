using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BallSpawning_shooting : MonoBehaviour
{
    public GameObject Ball;
    public GameObject Point;
    private Rigidbody rb;
    public Transform CameraTransform;
    public float BallSpeed = 20f;  // Velocità della palla

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            ShootBall();
        }
    }

    void ShootBall()
    {
        if (CameraTransform == null)
        {
            Debug.LogError("CameraTransform non assegnato!");
            return;
        }

        // Instanzia la palla nel punto di spawn
        GameObject newBall = Instantiate(Ball, Point.transform.position, Quaternion.identity);
        Debug.Log("SpawnPoint.forward: " + Point.transform.forward);
        // Ottieni il Rigidbody e applica velocità nella direzione della camera
        Rigidbody rb = newBall.GetComponent<Rigidbody>();
        rb.linearVelocity = Point.transform.forward * BallSpeed;
    }
    
    
    
    
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    /*void Start()
    {
        ball = Ball;
        float speed = 20.0f;
        rb = ball.GetComponent<Rigidbody>();
        Quaternion rotation = Quaternion.Euler( 0.0f, 0.0f, angle);
        Vector3 velocity = rotation * (Vector3.forward * speed);
        rb.linearVelocity = velocity;
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Input.touchCount > 0) {
            Touch touch = Input.GetTouch(0);
            if(Input.GetTouch(0).phase == TouchPhase.Ended){
                Quaternion rotation = Quaternion.Euler(Point.transform.rotation.x, Point.transform.rotation.y, angle);
                var position = Point.transform.position;
                Instantiate(ball, position, rotation);
            }
        }
    }*/
}
