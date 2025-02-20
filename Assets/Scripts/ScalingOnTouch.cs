using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class ScalingOnTouch : MonoBehaviour
{

    public Vector3 scale;
    public float startDistance;

    public GameObject obj; //oggetto da scalare

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       RaycastHit hit;
       Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
       if (Physics.Raycast(ray, out hit, 100)) {
            obj = hit.transform.gameObject;
       }

       if (Input.touchCount >= 2) {
            Touch touch1 = Input.GetTouch(0);
            Touch touch2 = Input.GetTouch(1);

            if (touch1.phase == TouchPhase.Began || touch2.phase == TouchPhase.Began) {
                startDistance = Vector2.Distance(touch1.position, touch2.position);
                scale = obj.transform.localScale;
            } else {
                Vector2 v1 = touch1.position;
                Vector2 v2 = touch2.position;

                float distance = Vector2.Distance(v1, v2);
                float factor = distance / startDistance;

                obj.transform.localScale = scale * factor;
            }
       }
    }
}
