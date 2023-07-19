using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject UI_inventory; // ������ ���������
    public Text WoodText; // ����� ��� ����������� ���������� �����
    public Text IronText; // ����� ��� ����������� ���������� ������
    public int WoodCount = 0; // ���������� �����
    public int IronCount = 0; // ���������� ������
    public int HaveAxe = 0;
    public int HaveIronAxe = 0;
    public Text TextHaveAxe;
    public Text TextHaveIronAxe;
    public GameObject ButtonInventory;
    public GameObject ExitButtonInventory;
    public GameObject playerInfo;


    private void Start()
    {
        UI_inventory.SetActive(false);
        ButtonInventory.SetActive(true);
        ExitButtonInventory.SetActive(false);
        WoodText.text = WoodCount.ToString();
        IronText.text = IronCount.ToString();
    }

    public void PlayerInventory()
    {
        UI_inventory.SetActive(true);
        ExitButtonInventory.SetActive(true);
    }

    public void PlayerInfo()
    {
        playerInfo.SetActive(true);
    }

    public void ExitPlayerInventory()
    {
        UI_inventory.SetActive(false);
        ExitButtonInventory.SetActive(false);
    }

    public void ExitPlayerInfo()
    {
        playerInfo.SetActive(false);
    }


    public void Update()
    {
       
    }

    public void WoodAddPlank()
    {
        // ����������� ���������� �����
        WoodCount += 5;

        // ��������� ����������� ���������� ����� � ��������� ����
        WoodText.text = WoodCount.ToString();
    }

    public void IronAddPlank()
    {
        // ����������� ���������� �����
        IronCount += 5;

        // ��������� ����������� ���������� ����� � ��������� ����
        IronText.text = IronCount.ToString();
    }
}





