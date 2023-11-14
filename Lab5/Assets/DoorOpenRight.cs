using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenRight : MonoBehaviour
{
    private bool isOpen = false;
    public float rotationSpeed = 30.0f;
    private float targetRotation = 90.0f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isOpen)
        {
            Debug.Log("jest");
            isOpen = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && isOpen)
        {
            Debug.Log("niejest");
            isOpen = false;
        }
    }
    void Update()
    {
        if (isOpen)
        {
            // Odczytaj obecn¹ rotacjê obiektu
            Vector3 currentRotation = transform.rotation.eulerAngles;

            if (currentRotation.y < targetRotation)
            {
                // Zaktualizuj rotacjê obiektu (zmieniaj¹c k¹t w osi Y)
                currentRotation.y += rotationSpeed * Time.deltaTime;

                // Ogranicz rotacjê do docelowego k¹ta
                currentRotation.y = Mathf.Min(currentRotation.y, targetRotation);

                // Przypisz zaktualizowan¹ rotacjê obiektowi
                transform.rotation = Quaternion.Euler(currentRotation);
            }
        }
    }
}
