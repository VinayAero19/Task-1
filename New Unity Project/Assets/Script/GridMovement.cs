using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GridMovement : MonoBehaviour
{

    Vector3 up = Vector3.zero,
    right = new Vector3(0, 90, 0),
    down = new Vector3(0, 180, 0),
    left = new Vector3(0, 270, 0),
    currentDir = Vector3.zero;
    public float speed = 5f;

    Vector3 nextPos, destination, direction;

    float rayLength = 1f;
    private Animator anim;
    
    private bool canMove;

    void Start()
    {
        currentDir = up;
        nextPos = Vector3.forward;
        destination = transform.position;
        anim = GetComponent<Animator>();

    }


    void Update()
    {
        Move();
        
    }

    void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);

        anim.SetBool("isIdle", false);
        if (Input.GetKey(KeyCode.W))
        {

            nextPos = Vector3.forward;
            currentDir = up;
            canMove = true;
            anim.SetBool("isWalking", true);
             

        }
        

        if (Input.GetKey(KeyCode.S))
        {
            nextPos = Vector3.back;
            currentDir = down;
            canMove = true;
            anim.SetBool("isWalking", true);

        }
        if (Input.GetKey(KeyCode.D))
        {
            nextPos = Vector3.right;
            currentDir = right;
            canMove = true;
            anim.SetBool("isWalking", true);

        }
        if (Input.GetKey(KeyCode.A))
        {
            nextPos = Vector3.left;
            currentDir = left;
            canMove = true;
            anim.SetBool("isWalking", true);

        }
       

        if (Vector3.Distance(destination, transform.position) <= 0.0001f)
        {
            transform.localEulerAngles = currentDir;
            if (canMove)
            { 
                if (Valid())
                {
                    
                    destination = transform.position + nextPos;
                    direction = nextPos;
                    canMove = false ;
                    anim.SetBool("isIdle", true);



                }
            }  

        }

    }
    bool Valid()
    {
        Ray myRay = new Ray(transform.position + new Vector3(0, 0.25f, 0), transform.forward);
        RaycastHit Hit;
        Debug.DrawRay(myRay.origin, myRay.direction, Color.red);
        if (Physics.Raycast(myRay, out Hit, rayLength))
        {
            if (Hit.collider.tag == "wall")
            {
                return false;
            }
        }
        return true;
    }

}


