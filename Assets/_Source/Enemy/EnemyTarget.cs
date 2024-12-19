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
            Vector3 direction = (player.position - transform.position).normalized;

            // Поворачиваем врага в сторону игрока
            if (direction != Vector3.zero) // Проверка, чтобы избежать ошибок при делении на ноль
            {

                // Отзеркаливаем модель по оси X в зависимости от положения игрока
                if (player.position.x < transform.position.x)
                {
                    // Игрок слева, отзеркаливаем модель
                    transform.localScale = new Vector3(-1, 1, 1);
                }
                else
                {
                    // Игрок справа, восстанавливаем нормальный масштаб
                    transform.localScale = new Vector3(1, 1, 1);
                }
            }

            // Перемещение врага к игроку
            transform.position += direction * speed * Time.deltaTime;
        }

        void AttackPlayer()
        {
            if (!isAttacking)
            {
                isAttacking = true;
                Player playerHealth = player.GetComponent<Player>();
                if (playerHealth != null)
                {
                    playerHealth.TakeDamage(damage);
                }

                Invoke("ResetAttack", 1f);
            }
        }

        void ResetAttack()
        {
            isAttacking = false;
        }
    }
}
