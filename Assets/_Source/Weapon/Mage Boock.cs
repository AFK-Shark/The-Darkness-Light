using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Weapon
{
    public class MageBook : MonoBehaviour
    {
        [SerializeField] private GameObject projectilePrefab;

        public void ShootProjectile(Vector2 direction)
        {
            GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);

            Projectile projectileScript = projectile.GetComponent<Projectile>();
            if (projectileScript != null)
            {
                projectileScript.Initialize(direction);
            }
        }
    }
}
