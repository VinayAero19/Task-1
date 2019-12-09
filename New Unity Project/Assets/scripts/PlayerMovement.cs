using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private Transform goal;
    private Animator anim;
    private bool mrunning = false;

    void Start()
    {
        anim = GetComponent<Animator>();
        var playerAgent = GetComponent<NavMeshAgent>();
        playerAgent.destination = goal.position;
        mrunning = true;
        anim.SetBool("running", mrunning);

        if(playerAgent.remainingDistance > playerAgent.stoppingDistance)
        {
            mrunning = false;
            anim.SetBool("running", mrunning);
        }

    }

    

    


    void Update()
    {
  

    }

}  
    

