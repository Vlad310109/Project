using System.Collections;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public int maxHealth = 20;
    private Rigidbody rb;
    public GameObject TextWood;
    public GameObject tree;
    public GameObject hitEffectPrefab; // Префаб эффекта удара
    public Inventory inventory;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true; // Начинаем с выключенной гравитации
    }

    public void TakeDamageTree(int damageAmount)
    {
        maxHealth -= damageAmount;

        if (maxHealth <= 0)
        {
            rb.isKinematic = false;
            rb.AddForce(Vector3.left * 50f, ForceMode.Impulse);
            StartCoroutine(Text());
            inventory.WoodAddPlank();
        }
    }

    public IEnumerator Text()
    {
        TextWood.SetActive(true);
        yield return new WaitForSeconds(5f);
        TextWood.SetActive(false);
        tree.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Axe") && PlayerMove.isHit == true)
        {
            TakeDamageTree(5);
        }
    }
}



