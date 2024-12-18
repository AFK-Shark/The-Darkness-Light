using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    [System.Serializable]
    public class Item
    {
        public string itemName;
        public Sprite itemImage;
        public Button buyButton;
        public GameObject itemDisplay; // ������, ������� ����� ���������� ��������� �������
    }

    public Item[] items; // ������ ���������
    public Transform inventoryPanel; // ������ ��� ����������� ��������� ���������

    void Start()
    {
        foreach (Item item in items)
        {
            item.buyButton.onClick.AddListener(() => BuyItem(item));
            item.itemDisplay.SetActive(false); // ������ ��������, ���� ��� ��� �� �������
        }
    }

    void BuyItem(Item item)
    {
        // ����� ����� �������� ������ ��� ��������, ���������� �� � ������ �������� ��� �������
        item.itemDisplay.SetActive(true); // ���������� ��������� �������
        Image itemImage = item.itemDisplay.GetComponent<Image>();
        if (itemImage != null)
        {
            itemImage.sprite = item.itemImage; // ������������� ����������� ��������
        }

        // ����������� ������ ����� ������� (���� ����������)
        item.buyButton.interactable = false;
    }
}