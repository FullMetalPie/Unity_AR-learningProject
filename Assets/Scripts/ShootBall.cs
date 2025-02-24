using UnityEngine;

public class ShootBall : MonoBehaviour
{
    public GameObject Ball;
    public GameObject camera;
    public Rigidbody rb;

    public void spawnBall() {
        GameObject spawnedBall;
        spawnedBall = Instantiate(Ball, camera.transform.position, camera.transform.rotation) as GameObject;
    }

    private void Update () {
        rb = rb.AddForce(Physics.gravity, ForceMode.Acceleration);
    }
}
