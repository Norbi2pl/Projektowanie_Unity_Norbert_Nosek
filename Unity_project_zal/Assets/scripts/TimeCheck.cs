using UnityEngine;
using UnityEngine.UI;

public class TimeCheck : MonoBehaviour
{
    public Text textTime;
    private float startTime;
    private bool currentTime = false;

    void Start()
    {
        if (textTime == null)
            Debug.LogError("Brak referencji do obiektu");

        StartCountTime();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            StopCountTime();
    }

    void StartCountTime()
    {
        startTime = Time.time;
        currentTime = true;
    }

    void StopCountTime()
    {
        currentTime = false;
    }

    void Update()
    {
        if (currentTime)
        {
            float howTime = Time.time - startTime;
            UpdateTime(howTime);
        }
    }

    void UpdateTime(float time)
    {
        string timeText = string.Format("{0}:{1:00}", (int)time / 60, time % 60);
        textTime.text = "Czas koncowy: " + timeText;
    }
}
