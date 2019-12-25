﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRag : MonoBehaviour
{

    void Start()
    {
        setRigidBodyState(true);
        setColliderState(false);
    }


    void Update()
    {
       
    }
    public void die()
    {
        Destroy(gameObject, 3f);
        GetComponent<Animator>().enabled = false;
        setRigidBodyState(false);
        setColliderState(true);
       
    }

    void setRigidBodyState(bool state)
    {
        Rigidbody[] rigidbodies = GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody rigidbody in rigidbodies)
        {
            rigidbody.isKinematic = state;
        }

        GetComponent<Rigidbody>().isKinematic = !state;
    }
    void setColliderState (bool state)
    {
        Collider[] colliders = GetComponentsInChildren<Collider>();
        foreach (Collider collider in colliders)
        {
            collider.enabled = state;
        }
        GetComponent<Collider>().enabled = !state;
    }

}

