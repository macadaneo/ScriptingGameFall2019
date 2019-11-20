using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerAttack : MonoBehaviour
{
    public GameObject throwableItem, attackArea;
    public float attackRecovery;
    private bool recovering;
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
            Instantiate(throwableItem, transform.position, transform.rotation);

        if (attackRecovery <= 0 && !recovering)
        {
            if (Input.GetKey(KeyCode.F))
            {
                Instantiate(attackArea, transform.position, Quaternion.identity);
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
