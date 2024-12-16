using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // �������� �������� ���������
    private Vector2 moveInput; // ������ ��� �������� ������� ������ ��������
    private Rigidbody2D rb; // ������ �� Rigidbody2D

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>(); // �������� ��������� Rigidbody2D
    }

    // ����� ��� ��������� ������� ������ ��������
    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>(); // ������ ������ ��������
    }

    private void FixedUpdate()
    {
        Move(); // �������� ����� ��������
    }

    private void Move()
    {
        Vector2 movement = moveInput * moveSpeed * Time.fixedDeltaTime; // ������������ ��������
        rb.MovePosition(rb.position + movement); // ���������� Rigidbody2D
    }
}
