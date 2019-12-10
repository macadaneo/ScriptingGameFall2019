using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerAttack : MonoBehaviour
{
    public GameObject throwableItem, attackArea;
    public float throwForce = 40f;
    public float attackRecovery;
    private bool recovering; 
    private Vector3 attackRange = new Vector3 (2, 0, 0);
  

   
    private void Update() //Need to fix this also refrence Bomb scripts.
    {

        if (Input.GetKeyUp(KeyCode.E))
        {
            ThrowBomb();
        }

        void ThrowBomb()
        {
            GameObject bomb = Instantiate(throwableItem, transform.position + attackRange, transform.rotation);
            Rigidbody rb = bomb.GetComponent<Rigidbody>();
            rb.AddForce(transform.right * throwForce, ForceMode.VelocityChange);
        }

        if (attackRecovery <= 0 && !recovering)
        {
            if (Input.GetKey(KeyCode.F))
            {
                Instantiate(attackArea, transform.position + attackRange, Quaternion.identity);
                attackRecovery = 1.5f;
                recovering = true;
            }
        }
        else
        {
            attackRecovery -= Time.deltaTime;
            recovering = false;
        }
    }
}
//made with help from Brackeys