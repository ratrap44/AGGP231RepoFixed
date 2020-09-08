using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Touch drag;
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            drag = Input.GetTouch(0);

            if (drag.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(transform.position.x + drag.deltaPosition.x * speed, transform.position.y, transform.position.z + drag.deltaPosition.y * speed);
            }
        }
        
    }
}
