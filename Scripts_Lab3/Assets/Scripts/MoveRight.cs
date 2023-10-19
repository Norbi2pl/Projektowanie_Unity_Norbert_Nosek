using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    public float speed;
    private bool movingRight = true; 
    void Update()
    {
        if (movingRight)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);

            if (transform.position.x >= 10.0f)
                movingRight = false;
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);

            if (transform.position.x <= 0.0f)
                movingRight = true;
        }
    }
}
