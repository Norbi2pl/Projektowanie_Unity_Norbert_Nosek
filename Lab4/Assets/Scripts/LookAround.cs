using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LookAround : MonoBehaviour
{
    public Transform player;
    public float sensitivity = 200f;
    private float xMin = -0.5f;
    private float xMax = 0.5f;
    private float timeValue = 0.0f;

    // Reference to UI sliders
    public Slider xMinSlider;
    public Slider xMaxSlider;

    // Reference to UI Text components to display xMin and xMax values
    public Text xMinText;
    public Text xMaxText;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseXMove = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseYMove = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        player.Rotate(Vector3.up * mouseXMove);
        transform.Rotate(new Vector3(-mouseYMove, 0f, 0f), Space.Self);

        float xValue = Mathf.Sin(timeValue * 5.0f);
        float xPos = Mathf.Clamp(xValue, xMin, xMax);

        transform.position = new Vector3(xPos, 0.0f, 0.0f);

        timeValue = timeValue + Time.deltaTime;

        if (xValue > Mathf.PI * 2.0f)
        {
            timeValue = 0.0f;
        }
    }

    void OnGUI()
    {
        // This method is now empty, as GUI handling has been moved to the Unity UI system.
        // You can delete this method as it's not used in this updated script.
    }

    // Update the xMin and xMax values when the sliders change
    public void UpdateXMin(float value)
    {
        xMin = value;
        xMinText.text = "xMin: " + value.ToString("f2");
    }

    public void UpdateXMax(float value)
    {
        xMax = value;
        xMaxText.text = "xMax: " + value.ToString("f2");
    }
}