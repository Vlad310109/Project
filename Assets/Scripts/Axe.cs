using UnityEngine;
using static Tree;

public class Axe : MonoBehaviour
{
    public GameObject hitEffectPrefab; // Префаб эффекта удара
    public ZombieDynamite zombieDynamite;

    private void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tree") && PlayerMove.isHit)
        {
            Vector3 hitPoint = transform.position; // Место контакта - позиция топора
            Instantiate(hitEffectPrefab, hitPoint, Quaternion.identity);
        }

        if (other.CompareTag("Zombie") && PlayerMove.isHit)
        {
            zombieDynamite.maxHealth -= 20;
        }
    }
}
