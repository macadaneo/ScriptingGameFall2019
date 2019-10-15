using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerAttack : MonoBehaviour
{
    public GameObject throwableItem;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
            Instantiate(throwableItem, transform.position, transform.rotation);
    }

}