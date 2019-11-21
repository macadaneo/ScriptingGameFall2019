using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee : MonoBehaviour
{
    public float delay = .5f, countdown;
    public Destructible Hit;
    public float HitBox = 1.5f;
      public void Start()
       {
           countdown = delay;
       }

    public void Update()
    {
          countdown -= Time.deltaTime;

          if (countdown <= 0)
          {
              Destroy(gameObject);
          }
          
    }

    private void Explode()
    {
        Debug.Log("Boom!");

        Collider[] colliders = Physics.OverlapSphere(transform.position, HitBox);

        foreach (Collider nearbyObject in colliders)
        {
            Destructible dest = nearbyObject.GetComponent<Destructible>();
            if (dest != null)
            {
                dest.OnHit();
            }
        }
    }
}
