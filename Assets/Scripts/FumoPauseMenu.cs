using UnityEngine;
using UnityEngine.SceneManagement;

public class FumoPauseMenu : MonoBehaviour
{
    public GameObject pauseCanvas;

    public void ShowPauseMenu()
    {
        pauseCanvas.SetActive(true);
    }

    public void HidePauseMenu()
    {
        pauseCanvas.SetActive(false);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Warning");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
