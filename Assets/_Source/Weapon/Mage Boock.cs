using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Weapon
{
    public class MageBook : MonoBehaviour
    {
        [SerializeField] private GameObject projectilePrefab;
        [SerializeField] private Camera mainCamera;

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                ShootProjectile();
            }
        }

        public void ShootProjectile()
        {
            Vector3 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0;

            GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);

            Vector2 direction = (mousePosition - transform.position).normalized;

            Projectile projectileScript = projectile.GetComponent<Projectile>();
            if (projectileScript != null)
            {
                projectileScript.Initialize(direction);
            }
        }
    }
}
