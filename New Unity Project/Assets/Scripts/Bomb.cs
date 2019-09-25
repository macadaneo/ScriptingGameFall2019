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
    public bool hasExploded = false, inDanger = false;
    public GameObject explosionEffect;


    // Start is called before the first frame update
    private void Start()
    {
        countdown = delay;
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
    
    private void OnTriggerEnter(Collider other)
            {
                inDanger = true;
            }
        
    private void OnTriggerExit(Collider other)
            {
                inDanger = false;
            }
    

    private void Explode()
    {
        Debug.Log("Boom!");
            Instantiate(explosionEffect, transform.position, transform.rotation);
            Event.Invoke();
            Destroy(gameObject);
        }
}
