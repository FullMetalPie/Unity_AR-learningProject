using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BallSpawning_shooting : MonoBehaviour
{
    public GameObject Ball;
    public GameObject Point;
    private GameObject ball;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Input.touchCount > 0) {
            Touch touch = Input.GetTouch(0);
            if(Input.GetTouch(0).phase == TouchPhase.Ended){
                var position = Point.transform.position;
                var rotation = Point.transform.rotation;
                ball = Instantiate(Ball, position, rotation);
            }
        }
    }
}
