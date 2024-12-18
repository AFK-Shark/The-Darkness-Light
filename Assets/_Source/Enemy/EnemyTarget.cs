using UnityEngine;
using player;

namespace Enemy
{
    public class EnemyTarget : MonoBehaviour
    {
        public Transform player;
        public float speed = 2f;
        public float attackRange = 1f;
        public int damage = 4;
        private bool isAttacking = false;
        public int mobHealth;

        void Update()
        {
            // Проверяем расстояние до игрока
            float distance = Vector3.Distance(transform.position, player.position);

            if (distance < attackRange)
            {
                // Начинаем атаку, если игрок в пределах досягаемости
                AttackPlayer();
            }
            else
            {
                // Перемещение к игроку
                MoveTowardsPlayer();
            }
        }

        void MoveTowardsPlayer()
        {
            // Двигаем моба к позиции игрока
            Vector3 direction = (player.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;
        }

        void AttackPlayer()
        {
            if (!isAttacking)
            {
                isAttacking = true;
                // Предполагается, что у вас есть метод, который отвечает за нанесение урона игроку
                Player playerHealth = player.GetComponent<Player>();
                if (playerHealth != null)
                {
                    playerHealth.TakeDamage(damage);
                }

                // Восстановление статуса атаки после небольшого промежутка времени
                Invoke("ResetAttack", 1f); // Задержка между атаками (1 секунда)
            }
        }

        void ResetAttack()
        {
            isAttacking = false;
        }
    }
}