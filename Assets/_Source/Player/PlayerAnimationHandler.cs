using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace player
{
    public class PlayerAnimationHandler : MonoBehaviour
    {
        private const string MOUEEWALK_PROPERTY = "Walk"; // Движение вниз
        private const string MOUSEWALKOUT_PROPERTY = "Out"; // Движение вверх
        private const string MOUSEWALKLEFT_PROPERTY = "Left"; // Движение влево
        private const string MOUSEWALKRIGHT_PROPERTY = "Right"; // Движение вправо
        private const string MOUSEIDLE_PROPERTY = "Idle"; // Обычная анимация

        private const string DEATH_PROPERTY = "Death";
        private const string NEXTLEVEL_PROPERTY = "NextLevel";

        [SerializeField] private Animator _animator;

        public void HandleMovementAnimation(Vector2 moveDirection)
        {
            bool isWalking = moveDirection.magnitude > 0;

            // Устанавливаем параметры анимации
            SetWalk(isWalking);
            SetIdle(!isWalking);

            // Устанавливаем направление движения
            SetOut(moveDirection.y > 0); // Движение вверх
            SetLeft(moveDirection.x < 0); // Движение влево
            SetRight(moveDirection.x > 0); // Движение вправо
        }

        public void SetIdle(bool value)
        {
            _animator.SetBool(MOUSEIDLE_PROPERTY, value);
        }

        public void SetWalk(bool value)
        {
            _animator.SetBool(MOUEEWALK_PROPERTY, value);
        }

        public void SetOut(bool value)
        {
            _animator.SetBool(MOUSEWALKOUT_PROPERTY, value);
        }

        public void SetLeft(bool value)
        {
            _animator.SetBool(MOUSEWALKLEFT_PROPERTY, value);
        }

        public void SetRight(bool value)
        {
            _animator.SetBool(MOUSEWALKRIGHT_PROPERTY, value);
        }

        public void PlayDeath()
        {
            _animator.SetTrigger(DEATH_PROPERTY);
        }

        public void PlayLevelSwitch()
        {
            _animator.SetTrigger(NEXTLEVEL_PROPERTY);
        }
    }
}
