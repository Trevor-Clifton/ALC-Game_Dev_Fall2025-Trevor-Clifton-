using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public float rotSpeed;
    public float hInput;
    public float vInput;
    public float jumpForce;
    public Rigidbody playerRB;
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.up * hInput * rotSpeed * Time.deltaTime); //left-right rotation
        transform.Translate(Vector3.right * vInput * speed * Time.deltaTime); //forward-back movement
        //playerRB.AddForce(transform.right * vInput * speed * Time.deltaTime, ForceMode.Impulse);
    }
}
