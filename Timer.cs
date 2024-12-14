using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 240f; // Timer starts at 60 seconds
    public bool isTimerRunning = false; // Controls whether the timer is running
    public TextMeshProUGUI timerText; // Reference to the TextMeshPro element

    void Start()
    {
        // Start the timer automatically
        isTimerRunning = true;
    }

    void Update()
    {
        if (isTimerRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                UpdateTimerDisplay(timeRemaining);
            }
            else
            {
                timeRemaining = 0;
                isTimerRunning = false;
                TimerEnded();
            }
        }
    }

    void UpdateTimerDisplay(float timeToDisplay)
    {
        // Format the time as MM:SS
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void TimerEnded()
    {
        Debug.Log("Timer has ended!");
        // Add any actions to take when the timer ends (e.g., show a message, trigger events)
    }
}
