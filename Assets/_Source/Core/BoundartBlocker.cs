using UnityEngine;

namespace core
{
    public class BoundaryBlocker : MonoBehaviour
    {
        public Rigidbody2D rb;

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        void Update()
        {
            Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            Vector2 newPosition = rb.position + moveInput * Time.deltaTime;

            if (!IsWithinPolygonCollider(newPosition))
            {
                return;
            }

            rb.MovePosition(newPosition);
        }

        private bool IsWithinPolygonCollider(Vector2 position)
        {
            Collider2D[] colliders = Physics2D.OverlapPointAll(position);
            foreach (var collider in colliders)
            {
                if (collider is PolygonCollider2D)
                {
                    return true;
                }
            }
            return false;
        }
    }

}