using UnityEngine;

public class Tree : MonoBehaviour
{
    public int maxHealth = 20;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true; // �������� � ����������� ����������
    }

    public void TakeDamage(int damageAmount)
    {
        maxHealth -= damageAmount;

        if (maxHealth <= 0)
        {
            rb.isKinematic = false; // �������� ����������, ����� ������ ������ ������
            rb.AddForce(Vector3.right * 50f, ForceMode.Impulse); // ��������� ���� ����������
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



