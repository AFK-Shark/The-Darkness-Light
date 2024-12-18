using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Weapon
{
    using UnityEngine;

    public class BookMovement : MonoBehaviour
    {
        public Transform player; // Ссылка на объект персонажа
        public float radius = 1f; // Радиус движения
        public float speed = 1f; // Скорость вращения
        public float heightAmplitude = 0.5f; // Амплитуда колебания вверх-вниз
        public float heightFrequency = 1f; // Частота колебания вверх-вниз

        private float angle;

        void Update()
        {
            // Обновляем угол вращения
            angle += speed * Time.deltaTime;

            // Вычисляем позицию книжки
            float x = player.position.x + radius * Mathf.Cos(angle);
            float z = player.position.z + radius * Mathf.Sin(angle);
            float y = player.position.y + heightAmplitude * Mathf.Sin(angle * heightFrequency);

            // Обновляем позицию книжки
            transform.position = new Vector3(x, y, z);
        }
    }

}