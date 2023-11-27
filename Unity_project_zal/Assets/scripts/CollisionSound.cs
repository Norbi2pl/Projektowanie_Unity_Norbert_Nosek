using UnityEngine;

public class CollisionSound : MonoBehaviour
{
    public AudioClip collisionSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayCollisionSound();
        }
    }

    private void PlayCollisionSound()
    {
        if (collisionSound != null)
        {
            AudioSource.PlayClipAtPoint(collisionSound, transform.position);
        }
    }
}
