using UnityEngine;
using Enemy;

namespace Weapon
{
    public class Projectile : MonoBehaviour
    {
        public float damage = 10f;
        public float lifetime = 5f;
        private Rigidbody2D rb;

        private void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        private void Start()
        {
            Destroy(gameObject, lifetime);
        }

        public void Initialize(Vector2 direction)
        {
            rb.velocity = direction * 10f;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Enemy"))
            {
                TestEnemy enemy = other.GetComponent<TestEnemy>();
                if (enemy != null)
                {
                    enemy.TakeDamage(damage);
                }

                Destroy(gameObject);
            }
        }
    }
}
