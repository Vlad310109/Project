using UnityEngine;

public class BoomZombie : MonoBehaviour
{
    public float explosionRadius = 5f;
    public int damageAmount = 50;
    public PlayerMove playerMove;
    public ZombieDynamite zombieDynamite;
    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && zombieDynamite.boom == true)
        {
            zombieDynamite.boom = true;
        }
    }
}
