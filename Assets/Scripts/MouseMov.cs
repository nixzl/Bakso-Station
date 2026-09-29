using UnityEngine;

public class MouseMov : MonoBehaviour
{
public float mouseSensitivty = 500f;

float xRotation = 0f;
float yRotation = 0f;

public float topClamp = 90f;
public float bottomClamp = -90f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivty * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivty * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, bottomClamp, topClamp);

        yRotation += mouseX;
        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
    }
}
