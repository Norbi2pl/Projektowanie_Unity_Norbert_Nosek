using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCollision : MonoBehaviour
{
    public float speed = 2f;
    private bool isRunning = false;
    public GameObject checkPoint;
    private bool isRunningRight = true;
    private bool isRunningDown = false;
    private float startPosition;
    private float endPosition;
    Transform oldParent;
    public GameObject Player;

    void Start()
    {
        startPosition = transform.position.x + checkPoint.transform.position.x;
        endPosition = transform.position.x;
    }

    void Update()
    {
        if (isRunningRight && transform.position.x >= startPosition)
        {
            isRunning = false;
        }
        else if (isRunningDown && transform.position.x <= endPosition)
        {
            isRunning = false;
        }

        if (isRunning)
        {
            Vector3 move = transform.right * speed * Time.deltaTime;
            transform.Translate(move);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            oldParent = Player.transform.parent;

            Player.transform.parent = transform;
            if (transform.position.x >= startPosition)
            {
                isRunningDown = true;
                isRunningRight = false;
                speed = -speed;
            }
            else if (transform.position.x <= endPosition)
            {
                isRunningRight = true;
                isRunningDown = false;
                speed = Mathf.Abs(speed);
            }
            isRunning = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Player)
        {
            Player.transform.parent = oldParent;
            if (transform.position.x >= startPosition)
            {
                isRunningDown = true;
                isRunningRight = false;
                speed = -speed;
            }
            else if (transform.position.x <= endPosition)
            {
                isRunningRight = true;
                isRunningDown = false;
                speed = Mathf.Abs(speed);
            }
            isRunning = true;
        }
    }
}
