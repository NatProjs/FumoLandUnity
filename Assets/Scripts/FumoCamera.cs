using UnityEngine;

public class FumoCamera : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public float rotationSpeed = 5f;
    private float cameraHeightOffset = 0.5f;

    private float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void LateUpdate()
    {
        if (target == null)
        {
            Debug.LogWarning("No target assigned to FumoCamera.");
            return;
        }

        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        target.Rotate(Vector3.up * mouseX);

        transform.rotation = Quaternion.Euler(xRotation, target.eulerAngles.y, 0f);

        Vector3 targetPosition = target.position + Vector3.up * cameraHeightOffset; // Add camera height offset
        transform.position = targetPosition - transform.forward * Vector3.Distance(targetPosition, transform.position);

        transform.LookAt(target);
    }
}
