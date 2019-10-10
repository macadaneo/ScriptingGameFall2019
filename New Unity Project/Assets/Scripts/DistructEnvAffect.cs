using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistructEnvAffect : DistructibleEnv
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
    
            public void OnDestroy()
            {
                if (Distructable == true)
                {
                    Event.Invoke();
                    Debug.Log("Environment Destroyed.");
                }
            }
}
