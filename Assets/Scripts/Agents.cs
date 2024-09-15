using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Agents : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    private GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        target = GameObject.Find("Target");
    }

    // Update is called once per frame
    void Update()
    {
        if(target != null) navMeshAgent.SetDestination(target.transform.position);
    }
}
