using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDynamite : MonoBehaviour
{
    public float speed = 1.5f;
    public int maxHealth = 100;
    public GameObject hitEffectPrefab; // Префаб эффекта удара
    public GameObject Zombie_Dynamite;
    public bool boom;
    public float movementSpeed = 2f;
    public float playerDetectionRadius = 10f;
    public float baseDetectionRadius = 15f;
    public Transform playerBase;
    private bool isDead = false; // Флаг, чтобы отслеживать смерть зомби

    private GameObject player;
    private Vector3 targetPosition;

    void Start()
    {
        boom = false;
        player = GameObject.FindGameObjectWithTag("Player");
        targetPosition = playerBase.position;
    }


    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
        float distanceToBase = Vector3.Distance(transform.position, playerBase.position);

        if (distanceToPlayer <= playerDetectionRadius)
        {
            targetPosition = player.transform.position;
        }

        else if (distanceToBase <= baseDetectionRadius)
        {
        }

        if (maxHealth <= 0 && !isDead)
        {
            isDead = true; // Устанавливаем флаг в true, чтобы выполнить следующий блок кода только один раз
            GameObject buf = Instantiate(hitEffectPrefab);
            buf.transform.position = Zombie_Dynamite.transform.position;
            Destroy(Zombie_Dynamite);
        }

        MoveTowardsTargetPosition();
    }


    private void MoveTowardsTargetPosition()
    {
        Vector3 direction = (targetPosition - transform.position).normalized;
        transform.position += direction * movementSpeed * Time.deltaTime;
        transform.LookAt(new Vector3(targetPosition.x, transform.position.y, targetPosition.z));
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Base"))
        {
            GameObject buf = Instantiate(hitEffectPrefab);
            buf.transform.position = Zombie_Dynamite.transform.position;
            Destroy(Zombie_Dynamite);
        }
    }
}


