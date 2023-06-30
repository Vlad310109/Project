using UnityEngine;
using static Tree;

public class Axe : MonoBehaviour
{
    public GameObject hitEffectPrefab; // ������ ������� �����

    private void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tree") && PlayerMove.isHitTree)
        {
            Vector3 hitPoint = transform.position; // ����� �������� - ������� ������
            Instantiate(hitEffectPrefab, hitPoint, Quaternion.identity);
        }
    }
}
