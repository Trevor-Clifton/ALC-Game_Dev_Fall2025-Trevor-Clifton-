using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 movement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            movement += Vector3.forward * 5 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            movement += Vector3.left * 5 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            movement += -Vector3.forward * 5 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            movement += Vector3.right * 5 * Time.deltaTime;
        }
        movement.Normalize();
        float y = transform.position.y;
        transform.Translate(movement* 5 * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, y, transform.position.z);
        movement = Vector3.zero;
    }
}
