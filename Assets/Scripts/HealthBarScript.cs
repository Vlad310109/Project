using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
    public Image healthBarFill; // ������ �� Image, ������� ������������ ���������� ������ ��������
    public PlayerMove playerMove;

    // ����� ��� ���������� ������ ��������
    public void UpdateHealthBar()
    {
        float fillAmount = playerMove.currentHealth / playerMove.maxHealth;
        healthBarFill.fillAmount = fillAmount;
    }

    // ���������� ��� ��������� �������� ������
    public void SetHealth(float newHealth)
    {
        playerMove.currentHealth = Mathf.Clamp(newHealth, 0f, playerMove.maxHealth); // ����������, ��� �������� ��������� � �������� �� 0 �� ������������� ��������
        UpdateHealthBar();
    }
}
