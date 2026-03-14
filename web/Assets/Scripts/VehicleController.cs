
using UnityEngine;

public class VehicleController : MonoBehaviour
{
    public float speed = 15f;

    void Update()
    {
        float v = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * v * speed * Time.deltaTime);
    }
}
