using UnityEngine;
using UnityEngine.InputSystem;

namespace player
{
    public class PlayerMoveControl : MonoBehaviour
    {
        [SerializeField] private Player _player;
        [SerializeField] private float _attackCooldown = 1.1f;

        private Vector2 _moveDirection;
        private float _moveSpeed;
        private bool isAttackAvailable = true;

        private void Awake()
        {
            _moveSpeed = _player.speed;
        }

        public void OnMove(InputAction.CallbackContext context)
        {
            _moveDirection = context.ReadValue<Vector2>();
        }

        public void OnAttack(InputAction.CallbackContext context)
        {
            if (isAttackAvailable && context.performed)
            {
                isAttackAvailable = false;
                Invoke(nameof(EnableAttack), _attackCooldown);
            }
        }

        public void OnSkills(InputAction.CallbackContext context)
        {
            if (context.performed) // Проверяем, что навык был использован
            {
                // Здесь можно добавить логику для навыка
            }
        }

        public void OnUsage(InputAction.CallbackContext context)
        {
            if (context.performed) // Проверяем, что использование было выполнено
            {
                // Здесь можно добавить логику для использования предметов
            }
        }

        private void Update()
        {
            Move(_moveDirection);
        }

        private void Move(Vector2 direction)
        {
            Vector3 moveDirection = new Vector3(direction.x, direction.y) * _moveSpeed * Time.deltaTime;
            transform.position += moveDirection;
        }

        private void EnableAttack()
        {
            isAttackAvailable = true;
        }
    }
}
