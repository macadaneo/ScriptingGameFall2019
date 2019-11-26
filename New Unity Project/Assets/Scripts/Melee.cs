using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Melee : MonoBehaviour
{
    public float delay = .5f, countdown;
    public float HitBox = 1.5f;
    private UnityEvent melee;
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
}
