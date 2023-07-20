using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ContinueTimer : MonoBehaviour
{
    public float timerDuration = 10f;
    public Text countdownText;
    private float timer;
    private bool isTimerRunning = true;

    void Start()
    {
        timer = timerDuration;
        UpdateCountdownText();
    }

    void Update()
    {
        if (isTimerRunning)
        {
            timer -= Time.deltaTime;

            if (timer <= 0f)
            {
                isTimerRunning = false;
                LoadScene();
            }

            UpdateCountdownText();
        }
    }

    void UpdateCountdownText()
    {
        countdownText.text = "" + Mathf.CeilToInt(timer).ToString();
    }

    void LoadScene()
    {
        SceneManager.LoadScene("Warning");
    }
}
