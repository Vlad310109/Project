using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject inventory; // Панель инвентаря
    public Text WoodText; // Текст для отображения количества досок
    private int WoodCount = 0; // Количество досок
    public bool ButtonInventory;
   

    private void Start()
    {
        // Скрываем панель инвентаря при запуске игры
        inventory.SetActive(false);
    }

    public void PlayerInventory()
    {
        ButtonInventory = true;
    }

    private void Update()
    {
        if (ButtonInventory == true)
        {
            inventory.SetActive(true);
        }
    }

    public void AddPlank()
    {
        // Увеличиваем количество досок
        WoodCount += 5;

        // Обновляем отображение количества досок в текстовом поле
        WoodText.text = WoodCount.ToString();
    }
}





