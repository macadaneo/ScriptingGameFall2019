using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class BombAffects : Bomb
{
   public void start()
    {
        inDanger = false;
    }
    
    public void OnTriggerEnter(Collider other)
        {
            inDanger = true;
        }
    
    
    
        public void OnTriggerExit(Collider other)
        {
            inDanger = false;
        }

        public void OnDestroy()
        {
            if (inDanger == true)
            {
                Event.Invoke();
                Debug.Log("Damage delt to character.");
            }
        }
}
