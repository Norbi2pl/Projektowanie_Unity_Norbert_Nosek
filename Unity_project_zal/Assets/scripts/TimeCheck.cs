using UnityEngine;

public class TimeCheck : MonoBehaviour
{
    private float startTime;
    private bool gameIsRunning = false;

    void Start()
    {
        StartGame();
    }

    void Update()
    {
        if (gameIsRunning)
        {
            float currentTime = Time.time - startTime;
            Debug.Log("Czas gry: " + currentTime.ToString("F2") + " sekundy");
        }
    }

    void StartGame()
    {
        startTime = Time.time;
        gameIsRunning = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameIsRunning = false;
            float endTime = Time.time;
            float totalTime = endTime - startTime;
            Debug.Log("Czas gry: " + totalTime.ToString("F2") + " sekundy");
        }
    }

}
