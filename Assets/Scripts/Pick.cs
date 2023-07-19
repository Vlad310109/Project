using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick : MonoBehaviour
{
    public GameObject hitEffectPrefab; // ������ ������� �����
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
            Vector3 hitPoint = transform.position; // ����� �������� - ������� �����
            Instantiate(hitEffectPrefab, hitPoint, Quaternion.identity);
        }
    }
}
