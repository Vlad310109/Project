using UnityEngine;

public class Tree : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;
    private Rigidbody rb;

    private void Start()
    {
        currentHealth = maxHealth;
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true; // Начинаем с выключенной гравитации
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        if (currentHealth <= 0)
        {
            rb.isKinematic = false; // Включаем гравитацию, чтобы дерево начало падать
            rb.AddForce(Vector3.down * 100f, ForceMode.Impulse); // Добавляем силу гравитации
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Axe") && PlayerMove.isHitTree)
        {
            maxHealth -= 5;
        }
    }
}



