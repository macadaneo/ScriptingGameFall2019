using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Object = System.Object;

public class Bomb : MonoBehaviour
{
    public UnityEvent Event;
    public float delay = 3f;
    private float countdown;
    private bool hasExploded = false;
    public GameObject explosionEffect;
    private void OnCollisionEnter(Collision other)
    {
        Event.Invoke();
    }

    // Start is called before the first frame update
    void Start()
    {
        countdown = delay;
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
            //show effect
            Instantiate(explosionEffect, transform.position, transform.rotation);
            // get nearby objects.
            //add force
            //damage
            
            Destroy(gameObject);
        }
}
