
using UnityEngine;

public class GunSystem : MonoBehaviour
{
    public int damage = 25;
    public float fireRate = 0.2f;
    float nextFire;

    void Update()
    {
        if(Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Shoot();
        }
    }

    void Shoot()
    {
        Debug.Log("Bang!");
    }
}
