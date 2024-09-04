using UnityEngine;
using UnityEngine.InputSystem;

public class ShootProjectile : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float projectileSpeed = 4000f;

    void Update()
    {
        if (Touchscreen.current.press.wasPressedThisFrame)
        {
            GameObject projectile = Instantiate(projectilePrefab, transform.position, transform.rotation);
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * projectileSpeed);
        }
    }
}