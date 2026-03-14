
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 6f;
    public float mouseSensitivity = 2f;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(h,0,v);
        transform.Translate(move * speed * Time.deltaTime);

        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        transform.Rotate(0, mouseX, 0);
    }
}
