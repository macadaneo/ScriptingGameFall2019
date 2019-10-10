using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructEnvAffect : DestructibleEnv
{
    public void start()
        {
            Distructable = false;
        }
        
        public void OnTriggerEnter(Collider other)
            {
                Distructable = true;
            }
        
        
        
            public void OnTriggerExit(Collider other)
            {
                Distructable = false;
            }
    
            public void OnDisable()
            {
                if (Distructable == true)
                {
                    Event.Invoke();
                    Debug.Log("Environment Destroyed.");
                }
            }
}
