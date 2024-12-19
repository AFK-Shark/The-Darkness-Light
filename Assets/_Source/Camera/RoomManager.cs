using Rooms;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public CameraController cameraController; // Ссылка на скрипт камеры
    public RoomVariants[] rooms; // Массив доступных комнат

    private void Start()
    {
        // Начнем с первой комнаты
        if (rooms.Length > 0)
        {
            cameraController.MoveToRoom(rooms[0].transform.position);
        }
    }

    public void ChangeRoom(int roomIndex)
    {
        if (roomIndex >= 0 && roomIndex < rooms.Length)
        {
            cameraController.MoveToRoom(rooms[roomIndex].transform.position);
        }
    }
}