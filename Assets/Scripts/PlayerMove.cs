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
    public GameObject IronAxe;
    public GameObject Axe;
    public GameObject UI_CraftInstrument;
    public GameObject UI_Craft_IronAxe;
    Animator anim;
    Vector3 direction;
    Rigidbody rb;
    [SerializeField] float rotationspeed;
    public Inventory inventory;
    public static bool isHit = true;
    public static bool isHitTree = false;
    public Transform targetObjectTree; // ������ �� ������ ������


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = player.GetComponent<Animator>();
        isHit = false;
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

    public void PlayerCraft()
    {
        UI_CraftInstrument.SetActive(true);
    }

    public void ExitPlayerCraft()
    {
        UI_CraftInstrument.SetActive(false);
    }

    public void CraftIronAxe()
    {
        UI_Craft_IronAxe.SetActive(true);
    }

    public void ExitCraftIronAxe()
    {
        UI_Craft_IronAxe.SetActive(false);
    }

    public void GetAxe()
    {
        Axe.SetActive(true);
        IronAxe.SetActive(false);
    }

    public void GetIronAxe()
    {
        if(inventory.HaveIronAxe >= 1)
        {
            Axe.SetActive(false);
            IronAxe.SetActive(true);
        }
        else
        {
            Debug.Log("� ��� ���� ��������� ������");
        }
    }

    public void Hit1()
    {
        isHit = true;
        StartCoroutine(IHit());
    }


    IEnumerator IHit()
    {
        anim.SetBool("Hit", true);
        yield return new WaitForSeconds(0.5f);
        anim.SetBool("Hit", false);
    }
}
