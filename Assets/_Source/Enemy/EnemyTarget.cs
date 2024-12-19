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
            // ��������� ���������� �� ������
            float distance = Vector3.Distance(transform.position, player.position);

            if (distance < attackRange)
            {
                // �������� �����, ���� ����� � �������� ������������
                AttackPlayer();
            }
            else
            {
                // ����������� � ������
                MoveTowardsPlayer();
            }
        }

        void MoveTowardsPlayer()
        {
            Vector3 direction = (player.position - transform.position).normalized;

            // ������������ ����� � ������� ������
            if (direction != Vector3.zero) // ��������, ����� �������� ������ ��� ������� �� ����
            {

                // ������������� ������ �� ��� X � ����������� �� ��������� ������
                if (player.position.x < transform.position.x)
                {
                    // ����� �����, ������������� ������
                    transform.localScale = new Vector3(-1, 1, 1);
                }
                else
                {
                    // ����� ������, ��������������� ���������� �������
                    transform.localScale = new Vector3(1, 1, 1);
                }
            }

            // ����������� ����� � ������
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
