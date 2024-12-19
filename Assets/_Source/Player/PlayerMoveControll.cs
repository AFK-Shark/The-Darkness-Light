using UnityEngine;
using UnityEngine.InputSystem;
using Weapon;

namespace player
{
    public class PlayerMoveControl : MonoBehaviour
    {
        [SerializeField] private Player _player;
        [SerializeField] private MageBook mageBook;
        [SerializeField] private float _attackCooldown = 0.5f;

        [SerializeField] private PlayerAnimationHandler _animationHandler;

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
            UpdateAnimation();
        }

        public void OnAttack(InputAction.CallbackContext context)
        {
            if (isAttackAvailable && context.performed)
            {
                isAttackAvailable = false;

                Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePosition.z = 0;

                Vector2 direction = (mousePosition - transform.position).normalized;

                mageBook.ShootProjectile(direction);
                Invoke(nameof(EnableAttack), _attackCooldown);
                Debug.Log("Attack");
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

        private void UpdateAnimation()
        {
            _animationHandler.HandleMovementAnimation(_moveDirection);
        }


        private void EnableAttack()
        {
            isAttackAvailable = true;
        }
    }
}
