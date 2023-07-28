using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
    public Image healthBarFill; // —сылка на Image, который представл€ет заполнение полосы здоровь€
    public PlayerMove playerMove;

    // ћетод дл€ обновлени€ полосы здоровь€
    public void UpdateHealthBar()
    {
        float fillAmount = playerMove.currentHealth / playerMove.maxHealth;
        healthBarFill.fillAmount = fillAmount;
    }

    // ¬ызываетс€ при изменении здоровь€ игрока
    public void SetHealth(float newHealth)
    {
        playerMove.currentHealth = Mathf.Clamp(newHealth, 0f, playerMove.maxHealth); // ”беждаемс€, что здоровье находитс€ в пределах от 0 до максимального значени€
        UpdateHealthBar();
    }
}
