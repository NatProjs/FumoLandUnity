using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceToPlay : MonoBehaviour
{
    public string FumoGame;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LoadScene();
        }
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(FumoGame);
    }
}
