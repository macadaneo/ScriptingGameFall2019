using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    public int a = 4, b = 5, c = 10;
    public string password = "Friend";
    public bool lightsOn = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
        
        if (a+b==c)
        {
            print("true");
        }
        
        if (password == "OU812")
        {
            print("true");
        }

        if (lightsOn)
        {
            print("true");
        }
    }
}
