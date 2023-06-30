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
        rb.isKinematic = true; // �������� � ����������� ����������
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        if (currentHealth <= 0)
        {
            rb.isKinematic = false; // �������� ����������, ����� ������ ������ ������
            rb.AddForce(Vector3.down * 100f, ForceMode.Impulse); // ��������� ���� ����������
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



