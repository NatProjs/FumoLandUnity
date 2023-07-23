using UnityEngine;

public class FumoSwap : MonoBehaviour
{
    public GameObject objectToDisable;
    public GameObject objectToEnable;

    private bool objectsEnabled = true;

    private void Update()
    {
        // Q (SHIFT FUMO)
        if (Input.GetKey(KeyCode.Joystick1Button2))
        {
            SwitchObjects();
        }
    }

    public void SwitchObjects()
    {
        if (objectsEnabled)
        {
            objectToDisable.SetActive(false);

            objectToEnable.SetActive(true);
        }
        else
        {
            objectToEnable.SetActive(false);

            objectToDisable.SetActive(true);
        }

        objectsEnabled = !objectsEnabled;
    }
}
