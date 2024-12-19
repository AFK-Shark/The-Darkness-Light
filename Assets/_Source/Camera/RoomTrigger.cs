using Rooms;
using UnityEngine;

public class RoomTrigger : MonoBehaviour
{
    public RoomSpawner roomSpawner; // ������ �� ������� ������
    public int roomsToSpawn = 1; // ���������� ������ ��� ���������

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < roomsToSpawn; i++)
            {
                roomSpawner.Spawn();
            }
        }
    }