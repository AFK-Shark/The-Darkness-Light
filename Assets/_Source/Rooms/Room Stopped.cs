using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rooms
{
    public class RoomStopped : MonoBehaviour
    {
        public GameObject block;
        private void OnTriggerStay2D(Collider2D other)
        {
            if (other.CompareTag("block"))
            {
                Instantiate(block, transform.GetChild(0).position, Quaternion.identity);
                Instantiate(block, transform.GetChild(1).position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }

}