using System;
using Unity.VisualScripting;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firePoint;
    
    [SerializeField] private GameObject hitParticle;
    [SerializeField] private GameObject destroyParticle;

    private void RotateWeapon(float angle)
    {
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    public void Fire()
    {
        if (Input.GetKeyDown("Fire"))
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
        // Add logic for bullet movement and collision here
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy") || other.CompareTag("Ground"))
        {
            // Enemy damage
            
            Destroy(gameObject);
            Destroy(destroyParticle);
        }
    }
}