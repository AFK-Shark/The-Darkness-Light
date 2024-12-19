using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace player
{
    public class PlayerAnimationHandler : MonoBehaviour
    {
        private const string MOUEEWALK_PROPERTY = "Walk"; // �������� ����
        private const string MOUSEWALKOUT_PROPERTY = "Out"; // �������� �����
        private const string MOUSEWALKLEFT_PROPERTY = "Left"; // �������� �����
        private const string MOUSEWALKRIGHT_PROPERTY = "Right"; // �������� ������
        private const string MOUSEIDLE_PROPERTY = "Idle"; // ������� ��������

        private const string DEATH_PROPERTY = "Death";
        private const string NEXTLEVEL_PROPERTY = "NextLevel";

        [SerializeField] private Animator _animator;

        public void HandleMovementAnimation(Vector2 moveDirection)
        {
            bool isWalking = moveDirection.magnitude > 0;

            // ������������� ��������� ��������
            SetWalk(isWalking);
            SetIdle(!isWalking);

            // ������������� ����������� ��������
            SetOut(moveDirection.y > 0); // �������� �����
            SetLeft(moveDirection.x < 0); // �������� �����
            SetRight(moveDirection.x > 0); // �������� ������
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
