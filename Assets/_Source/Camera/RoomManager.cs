using Rooms;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public CameraController cameraController; // ������ �� ������ ������
    public RoomVariants[] rooms; // ������ ��������� ������

    private void Start()
    {
        // ������ � ������ �������
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