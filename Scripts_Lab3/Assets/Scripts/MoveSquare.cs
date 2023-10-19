using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSquare : MonoBehaviour
{
    public float speed = 10.0f;
    private float rotateAngle = 90.0f;
    private Vector3 currentPosition;
    private int movingDirection;

    void Start()
    {
        currentPosition = transform.position;
        movingDirection = 4;
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (movingDirection == 1)
        {
            if (transform.position.x > currentPosition.x + speed)
            {
                transform.Rotate(0.0f, rotateAngle, 0.0f);
                currentPosition = transform.position;
                movingDirection = 2;
            }
        }
        if (movingDirection == 2)
        {
            if (transform.position.z < currentPosition.z - speed)
            {
                transform.Rotate(0.0f, rotateAngle, 0.0f);
                currentPosition = transform.position;
                movingDirection = 3;
            }
        }
        if (movingDirection == 3)
        {
            if (transform.position.x < currentPosition.x - speed)
            {
                transform.Rotate(0.0f, rotateAngle, 0.0f);
                currentPosition = transform.position;
                movingDirection = 4;
            }
        }
        if (movingDirection == 4)
        {
            if (transform.position.z > currentPosition.z + speed)
            {
                transform.Rotate(0.0f, rotateAngle, 0.0f);
                currentPosition = transform.position;
                movingDirection = 1;
            }
        }
    }
}
