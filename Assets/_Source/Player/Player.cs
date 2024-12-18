using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace player
{
    public class Player : MonoBehaviour
    {
        public int attackPower = 1;
        public int hp = 1;
        public float speed = 5f;
        public float skillSpeed = 8f;
        public float attackRadius = 5f;

        public int health = 10; 

        public void TakeDamage(int damage)
        {
            health -= damage;
            Debug.Log("Player took damage: " + damage);
            if (health <= 0)
            {
                Die();
            }
        }

        void Die()
        {
            Debug.Log("Player died!");
            // Логика смерти игрока (например, перезагрузка игры или анимация смерти)
        }
    }

}