using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;
        float yDir = 0.0f;
        float xDir = 0.0f;
        if (Input.GetKey(KeyCode.W))
        {
            yDir = 1.0f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            yDir = -1.0f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            xDir = 1.0f;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            xDir = -1.0f;
        }

        float dy = yDir * speed * dt;
        transform.position = transform.position + new Vector3(0.0f, dy, 0.0f);
        float dx = xDir * speed * dt;
        transform.position = transform.position + new Vector3(dx, 0.0f, 0.0f);
    }
}
