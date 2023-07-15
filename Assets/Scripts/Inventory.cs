using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject inventory; // ������ ���������
    public Text WoodText; // ����� ��� ����������� ���������� �����
    private int WoodCount = 0; // ���������� �����
    public bool ButtonInventory;
   

    private void Start()
    {
        // �������� ������ ��������� ��� ������� ����
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
        // ����������� ���������� �����
        WoodCount += 5;

        // ��������� ����������� ���������� ����� � ��������� ����
        WoodText.text = WoodCount.ToString();
    }
}





