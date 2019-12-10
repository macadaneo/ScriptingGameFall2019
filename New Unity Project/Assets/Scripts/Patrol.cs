using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Patrol : MonoBehaviour
{
    public float speed;
    private float waitTime;
    public float startWaitTime;
    public float minX, minY, maxX, maxY;
    
    public Transform moveSpot;
    private int randomSpot;
    

    void Start()
    {
        waitTime = startWaitTime;
        moveSpot.position = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY));
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, moveSpot.position, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, moveSpot.position) < 0.2f)
        {
            if (waitTime <= 0)
            {
                moveSpot.position = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY));
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
    }
}
//made with help from Blackthronprod