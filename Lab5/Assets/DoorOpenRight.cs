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
            // Odczytaj obecn� rotacj� obiektu
            Vector3 currentRotation = transform.rotation.eulerAngles;

            if (currentRotation.y < targetRotation)
            {
                // Zaktualizuj rotacj� obiektu (zmieniaj�c k�t w osi Y)
                currentRotation.y += rotationSpeed * Time.deltaTime;

                // Ogranicz rotacj� do docelowego k�ta
                currentRotation.y = Mathf.Min(currentRotation.y, targetRotation);

                // Przypisz zaktualizowan� rotacj� obiektowi
                transform.rotation = Quaternion.Euler(currentRotation);
            }
        }
    }
}
