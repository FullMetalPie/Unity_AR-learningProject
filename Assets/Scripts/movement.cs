using UnityEngine;
using System;

public class movement : MonoBehaviour
{
    public float speed;
    private float angle = 45f;
    private Rigidbody rb;
    
    public GameObject Cam;
    void Start()
    {
        angle = 45; //Math.Abs(Cam.transform.rotation.z);
        rb = GetComponent<Rigidbody>();
        Quaternion rotation = Quaternion.Euler( Cam.transform.rotation.x, Cam.transform.rotation.y, angle);
        Vector3 velocity = rotation * (Vector3.forward * speed);

        rb.linearVelocity = velocity;
        //rb.AddForce(new Vector3(power * speed, fly * speed, power * speed));
    }
}
