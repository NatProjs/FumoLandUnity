using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceToPlay : MonoBehaviour
{
    public string FumoGame;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Joystick1Button7))
        {
            LoadScene();
        }
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(FumoGame);
    }
}
