using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    public float dely = 3f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,dely);
    }

    public void DestroyOnImpact()
    {
        Destroy(gameObject);
    }
}
