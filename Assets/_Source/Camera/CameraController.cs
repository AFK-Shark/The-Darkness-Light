using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // ����� ��� ������, �� ������� ����� ��������� ������
    public float moveSpeed = 2f; // �������� ����������� ������

    private void Update()
    {
        if (target != null)
        {
            Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        }
    }