using UnityEngine;

namespace Enemy
{
    public class TestEnemy : MonoBehaviour
    {
        public float health = 50f;

        public void TakeDamage(float damage)
        {
            health -= damage;
            if (health <= 0)
            {
                Die();
            }
        }

        private void Die()
        {
            Destroy(gameObject);
        }
    }

}