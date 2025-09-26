using UnityEngine;

public class Look : MonoBehaviour
{
    float mouseX;
    float mouseY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mouseX = 0;
        mouseY = 0;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        mouseX += Input.GetAxis("Mouse X")*1600*Time.deltaTime;
        mouseY += Input.GetAxis("Mouse Y")*1600*Time.deltaTime;

        mouseY = Mathf.Clamp(mouseY, -45f, 45f);

        transform.eulerAngles = new Vector3(-mouseY, mouseX, 0f);

    }
}
