using UnityEngine;

public class Example : MonoBehaviour
{
    // Smooth towards the height of the target

    public Transform target;
    public float smoothTime = 0.5f;
    public float yVelocity = 0.2f;

    void Update()
    {
        float newPosition = Mathf.SmoothDamp(transform.position.y, target.position.y, ref yVelocity, smoothTime);
        transform.position = new Vector3(transform.position.x, newPosition, transform.position.z);
    }
}
