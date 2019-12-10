using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{

    public Transform goal;
    private NavMeshAgent agent;
    private Animator anim;
    private bool mrunning = false;
    private bool shoot;
    

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        agent.destination = goal.position;
        mrunning = true;


    }
    void Update()
    {
 
        if(agent.remainingDistance < agent.stoppingDistance)
        {
            mrunning = false;
            shoot = true;
            anim.SetTrigger("shoot");

        }
        anim.SetBool("running", mrunning);
        


    }
}