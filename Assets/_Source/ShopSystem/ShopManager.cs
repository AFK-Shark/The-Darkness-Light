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
        public GameObject itemDisplay; // Объект, который будет отображать купленный предмет
    }

    public Item[] items; // Массив предметов
    public Transform inventoryPanel; // Панель для отображения купленных предметов

    void Start()
    {
        foreach (Item item in items)
        {
            item.buyButton.onClick.AddListener(() => BuyItem(item));
            item.itemDisplay.SetActive(false); // Скрыть предметы, если они еще не куплены
        }
    }

    void BuyItem(Item item)
    {
        // Здесь можно добавить логику для проверки, достаточно ли у игрока ресурсов для покупки
        item.itemDisplay.SetActive(true); // Отображаем купленный предмет
        Image itemImage = item.itemDisplay.GetComponent<Image>();
        if (itemImage != null)
        {
            itemImage.sprite = item.itemImage; // Устанавливаем изображение предмета
        }

        // Деактивация кнопки после покупки (если необходимо)
        item.buyButton.interactable = false;
    }
}