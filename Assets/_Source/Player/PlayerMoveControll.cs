using UnityEngine;
using UnityEngine.InputSystem;
using Weapon;

namespace player
{
    public class PlayerMoveControl : MonoBehaviour
    {
        [SerializeField] private Player _player;
        [SerializeField] private MageBook mageBook; // —сылка на скрипт MageBook
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
                mageBook.ShootProjectile();
                Invoke(nameof(EnableAttack), _attackCooldown);
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
