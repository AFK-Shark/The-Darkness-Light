using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Weapon
{
    using UnityEngine;

    public class BookMovement : MonoBehaviour
    {
        public Transform player;
        public float radius = 1f;
        public float speed = 1f;
        public float heightAmplitude = 0.5f;
        public float heightFrequency = 1f;

        private float angle;

        void Update()
        {
            angle += speed * Time.deltaTime;

            float x = player.position.x + radius * Mathf.Cos(angle);
            float z = player.position.z + radius * Mathf.Sin(angle);
            float y = player.position.y + heightAmplitude * Mathf.Sin(angle * heightFrequency);

            transform.position = new Vector3(x, y, z);
        }
    }

}