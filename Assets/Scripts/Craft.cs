using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Craft : MonoBehaviour
{
    public Inventory inventory;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void MadeIronAxe()
    {
        if(inventory.WoodCount >= 40 && inventory.IronCount >= 40)
        {
            inventory.WoodCount -= 40;
            inventory.IronCount -= 40;
            inventory.HaveIronAxe += 1;
            inventory.TextHaveIronAxe.text = inventory.HaveAxe.ToString();
            Debug.Log("Топор Сделан!");
        }
        
        else
        {
            Debug.Log("Недостаточно Ресурсов!");
        }
    }
}
