
using UnityEngine;

public class PlaneDrop : MonoBehaviour
{
    public float speed = 40f;

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
