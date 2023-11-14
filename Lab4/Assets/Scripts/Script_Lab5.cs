using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Lab5 : MonoBehaviour
{ 
    public float forceMultiplier = 30.0f; // Mno¿nik si³y wyrzutu gracza

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CharacterController playerController = other.GetComponent<CharacterController>();

            if (playerController != null)
            {
                Vector3 force = Vector3.up * forceMultiplier * 200.0f;
                playerController.Move(force * Time.deltaTime);
            }
        }
    }
}
