using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Axe;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float speed = 5;
    [SerializeField] Joystick joystick;
    [SerializeField] GameObject player;
    [SerializeField] GameObject HitAttack;
    [SerializeField] GameObject HitTree;
    Animator anim;
    Vector3 direction;
    Rigidbody rb;
    [SerializeField] float rotationspeed;
    public static bool isHit = true;
    public static bool isHitTree = false;
    public Transform targetObjectTree; // Ссылка на объект дерева


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = player.GetComponent<Animator>();
    }

   
    void Update()
    {
        float horizontal = joystick.Horizontal;
        float vertical = joystick.Vertical;
        direction = transform.TransformDirection(horizontal, 0, vertical);
        anim.SetFloat("Speed", Vector3.ClampMagnitude(direction,1).magnitude);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + direction * speed * Time.fixedDeltaTime);
        if (direction != new Vector3(0,0,0))
        {
            player.transform.rotation = Quaternion.Lerp(player.transform.rotation, Quaternion.LookRotation(direction), Time.fixedDeltaTime * rotationspeed);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tree"))
        {
            HitAttack.SetActive(false); // Активируем первую кнопку
            HitTree.SetActive(true); // Деактивируем вторую кнопку
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Tree"))
        {
            HitAttack.SetActive(true); // Активируем первую кнопку
            HitTree.SetActive(false); // Деактивируем вторую кнопку
        }
    }

    public void Hit1()
    {
        StartCoroutine(IHit());
    }

    public void Hit2()
    {
        StartCoroutine(IHit2());
    }

    IEnumerator IHit2()
    {
        isHitTree = true;
        yield return new WaitForSeconds(1f);
        isHitTree = false;
    }

    IEnumerator IHit()
    {
        isHit = true;
        anim.SetBool("Hit", true);
        yield return new WaitForSeconds(0.5f);
        isHit = false;
        anim.SetBool("Hit", false);
    }
}
