using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombAffects : Bomb
{
    private void OnTriggerEnter(Collider other)
        {
            inDanger = true;
        }
    
        private void OnTriggerExit(Collider other)
        {
            inDanger = false;
        }

        private void Update()
        {
            if (inDanger == true && hasExploded == true)
            {
                Event.Invoke();
            }
        }
}
