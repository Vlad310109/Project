using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    public int maxHealth = 20;
    public GameObject iron;
    public Inventory inventory;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void TakeDamageIron(int damageAmount)
    {
        maxHealth -= damageAmount;

        if (maxHealth <= 0)
        {
            Destroy(iron);
            inventory.IronAddPlank();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pick") && PlayerMove.isHit)
        {
            TakeDamageIron(5);
        }
    }
}
