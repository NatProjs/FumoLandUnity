using UnityEngine;

public class FumoSwap : MonoBehaviour
{
    public GameObject objectToDisable;
    public GameObject objectToEnable;

    private bool objectsEnabled = true;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
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
