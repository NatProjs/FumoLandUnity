using UnityEngine;

public class FumoPause : MonoBehaviour
{
    public GameObject objectToDisable;
    public GameObject objectToEnable;
    public MonoBehaviour scriptToDisable1;
    public MonoBehaviour scriptToDisable2;

    private bool objectsEnabled = true;
    private bool script1WasEnabled = true;
    private bool script2WasEnabled = true;

    private void Start()
    {
        script1WasEnabled = scriptToDisable1.enabled;
        script2WasEnabled = scriptToDisable2.enabled;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SwitchObjects();
        }
    }

    private void FixedUpdate()
    {
        if (!objectsEnabled)
        {
            DisableScripts();
            UnlockCursor();
        }
        else if (script1WasEnabled || script2WasEnabled)
        {
            EnableScripts();
            LockCursor();
        }
    }

    public void SwitchObjects()
    {
        if (objectsEnabled)
        {
            DisableObjects();
        }
        else
        {
            EnableObjects();
        }

        objectsEnabled = !objectsEnabled;
    }

    private void DisableObjects()
    {
        objectToDisable.SetActive(false);
        objectToEnable.SetActive(true);
        UnlockCursor();
    }

    private void EnableObjects()
    {
        objectToEnable.SetActive(false);
        objectToDisable.SetActive(true);
        LockCursor();
    }

    private void DisableScripts()
    {
        if (scriptToDisable1 != null)
        {
            scriptToDisable1.enabled = false;
        }

        if (scriptToDisable2 != null)
        {
            scriptToDisable2.enabled = false;
        }
    }

    private void EnableScripts()
    {
        if (script1WasEnabled && scriptToDisable1 != null)
        {
            scriptToDisable1.enabled = true;
        }

        if (script2WasEnabled && scriptToDisable2 != null)
        {
            scriptToDisable2.enabled = true;
        }
    }

    private void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void UnlockCursor()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
