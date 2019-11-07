using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerAttack : MonoBehaviour
{
    public GameObject throwableItem;
    private float timeToAttack, attackRecovery, attackRange;
    public Transform attackPosition;
    public SphereCollider attackArea;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
            Instantiate(throwableItem, transform.position, transform.rotation);

        if (attackRecovery <= 0)
        {
            if (Input.GetKey(KeyCode.F))
            {
                Instantiate(attackArea, transform.position, transform.rotation);
                Destroy(gameObject);
            }
        }
        else
        {
            attackRecovery -= Time.deltaTime;
        }
    }
    
}
