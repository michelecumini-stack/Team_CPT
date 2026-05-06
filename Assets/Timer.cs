using UnityEngine;
using TMPro; // Rimuovi se usi Text standard e usa UnityEngine.UI

public class Timer : MonoBehaviour
{
    public float timeRemaining = 60f; // Tempo iniziale in secondi
    public bool timerIsRunning = false;
    public TMP_Text timeText;
    private UIManager UI;

    private void Start()
    {
        // Il timer parte quando vuoi (puoi chiamarlo dal tasto Start)
        timerIsRunning = true;
        UI = FindAnyObjectByType<UIManager>();
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Tempo scaduto!");
                timeRemaining = 0;
                timerIsRunning = false;
                TriggerGameOver();
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void TriggerGameOver()
    {
        UI.ShowGameOverUI();
        Time.timeScale = 0f; // Ferma il gioco
        Cursor.lockState = CursorLockMode.None; // Sblocca il mouse
        Cursor.visible = true;
    }
}

