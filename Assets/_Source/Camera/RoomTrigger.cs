using Rooms;
using UnityEngine;

public class RoomTrigger : MonoBehaviour
{
    public RoomSpawner roomSpawner; // Ссылка на спавнер комнат
    public int roomsToSpawn = 1; // Количество комнат для генерации

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