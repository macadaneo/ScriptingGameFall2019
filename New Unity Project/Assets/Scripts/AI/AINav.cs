using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class AINav : MonoBehaviour
{

    private NavMeshAgent agent;
    public Vector3Data location;
    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        agent.destination = location.value;
    }
}
