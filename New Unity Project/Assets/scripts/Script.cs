using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Script : MonoBehaviour
{
    private Animator anim;
    private NavMeshAgent navMeshAgent;
    private bool mrunning = false;

    void Start()
    {
        anim = GetComponent<Animator>();
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Input.GetMouseButtonDown(0))
        {
            if(Physics.Raycast(ray,out hit,100))
            {
                navMeshAgent.destination = hit.point;
            }
        }

        if (navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance)
        {
            mrunning = false;
        }
        else
            mrunning = true;
        anim.SetBool("running", mrunning);
    }
}
