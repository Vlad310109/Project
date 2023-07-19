using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick : MonoBehaviour
{
    public GameObject hitEffectPrefab; // Префаб эффекта удара
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Iron") && PlayerMove.isHit)
        {
            Vector3 hitPoint = transform.position; // Место контакта - позиция кирки
            Instantiate(hitEffectPrefab, hitPoint, Quaternion.identity);
        }
    }
}
