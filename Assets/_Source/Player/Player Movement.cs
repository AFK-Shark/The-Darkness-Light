using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Скорость движения персонажа
    private Vector2 moveInput; // Вектор для хранения входных данных движения
    private Rigidbody2D rb; // Ссылка на Rigidbody2D

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>(); // Получаем компонент Rigidbody2D
    }

    // Метод для получения входных данных движения
    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>(); // Читаем вектор движения
    }

    private void FixedUpdate()
    {
        Move(); // Вызываем метод движения
    }

    private void Move()
    {
        Vector2 movement = moveInput * moveSpeed * Time.fixedDeltaTime; // Рассчитываем движение
        rb.MovePosition(rb.position + movement); // Перемещаем Rigidbody2D
    }
}
