using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    public GameObject txt;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag.Equals("Ball")) {
            //txt.text += 1;
        }
    }
}
