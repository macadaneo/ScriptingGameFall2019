using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Object = System.Object;

public class Bomb : MonoBehaviour
{
    public UnityEvent Event;
    public float delay = 3f, countdown;
    public GameObject explosionEffect;
    public bool hasExploded = false, inDanger = false;
    public float blastRadius = 5f, force = 700f;
    //private Unityevent damage;

    // Start is called before the first frame update
    private void Start()
    {
        countdown = delay;
    }
    
    
    public void OnTriggerEnter(Collider other)
        {
            inDanger = true;
        }

    public void OnTriggerStay(Collider other)
    {
        inDanger = true;
    }

    public void OnTriggerExit(Collider other)
    {
        inDanger = false;
    }


    // Update is called once per frame
    private void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0f && !hasExploded)
        {
            Explode();
            hasExploded = true;
        }
    }

    private void Explode()
    {
        Debug.Log("Boom!");
        Instantiate(explosionEffect, transform.position, transform.rotation);

        Collider[] colliders = Physics.OverlapSphere(transform.position, blastRadius);

        foreach (Collider nearbyObject in colliders)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(force, transform.position, blastRadius);
            }

            Destructible dest = nearbyObject.GetComponent<Destructible>();
            if (dest != null)
            {
                dest.Destruct();
            }
        }

        if (inDanger == true && countdown <= 0)
        {
            Event.Invoke();
        }

        Destroy(gameObject);

    }
}
//made with help from brackeys