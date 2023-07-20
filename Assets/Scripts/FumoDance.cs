using UnityEngine;

public class FumoDance : MonoBehaviour
{
    public Transform fumoTransform;
    public AudioSource audioSource;
    public float tiltAngle = 15f;
    public float tiltSpeed = 2f;

    private bool isDancing = false;
    private bool isAudioPlaying = false;
    private Quaternion initialRotation;

    private void Start()
    {
        initialRotation = fumoTransform.localRotation;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (!isAudioPlaying)
            {
                audioSource.Play();
                isAudioPlaying = true;
            }

            StartDance();
        }

        if (isDancing)
        {
            Dance();
        }

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) ||
            Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D) ||
            Input.GetKeyDown(KeyCode.Space))
        {
            StopDance();
        }
    }

    private void StartDance()
    {
        isDancing = true;
    }

    private void Dance()
    {
        float tiltAmount = Mathf.Sin(Time.time * tiltSpeed) * tiltAngle;
        Quaternion newRotation = Quaternion.Euler(initialRotation.eulerAngles.x, initialRotation.eulerAngles.y, tiltAmount);
        fumoTransform.localRotation = Quaternion.Lerp(fumoTransform.localRotation, newRotation, Time.deltaTime);
    }

    private void StopDance()
    {
        isDancing = false;
        fumoTransform.localRotation = initialRotation;

        if (isAudioPlaying)
        {
            audioSource.Stop();
            isAudioPlaying = false;
        }
    }
}
