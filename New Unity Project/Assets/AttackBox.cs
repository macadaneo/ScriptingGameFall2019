using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Attacking");
        Destroy(gameObject);
        Debug.Log("Recovery");
    }

}
