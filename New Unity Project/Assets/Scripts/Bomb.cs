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
    void Start()
    {
        countdown = delay;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        inDanger = true;
    }
    
    private void OnTriggerExit(Collider other)
    {
        inDanger = false;
    }
    
    // Update is called once per frame
    void Update()
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
            Event.Invoke();
            Instantiate(explosionEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
}
