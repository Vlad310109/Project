using UnityEngine;

public class Tree : MonoBehaviour
{
    public int maxHealth = 20;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true; // Начинаем с выключенной гравитации
    }

    public void TakeDamage(int damageAmount)
    {
        maxHealth -= damageAmount;

        if (maxHealth <= 0)
        {
            rb.isKinematic = false; // Включаем гравитацию, чтобы дерево начало падать
            rb.AddForce(Vector3.right * 50f, ForceMode.Impulse); // Добавляем силу гравитации
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Axe") && PlayerMove.isHitTree)
        {
            TakeDamage(5);
        }
    }
}



