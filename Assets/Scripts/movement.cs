using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 1;
    private Rigidbody rb;
    private float movementX;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    // Update is called once per frame
    private void FixedUpdate() {
        Vector3 movement = new Vector3(0.1f, 0.0f, 0.0f);
        rb.AddForce(movement * speed);
    }
}
