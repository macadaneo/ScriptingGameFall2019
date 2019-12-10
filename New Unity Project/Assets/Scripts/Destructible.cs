using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class Destructible : MonoBehaviour
{
    //public float EnvoHealth = .3f;
    public ParticleSystem rubble; 
    

    public void Destruct()
    {
        Instantiate(rubble, transform.position, transform.rotation);
        Destroy(gameObject);
    }

  /*  public void OnTriggerEnter()
    {
        Debug.Log("Hit!");
        EnvoHealth -= .1f;
        if (EnvoHealth <= 0)
        {
            Destruct();
        }
    }*/
}
