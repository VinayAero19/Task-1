using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{

    public Rigidbody bullet;
    public Transform firepoint;
    public int damage = 50;
    public float bulletspeed;



    void Fire()
    {
       
        Rigidbody bulletClone = (Rigidbody)Instantiate(bullet, firepoint.position, firepoint.rotation);
        bulletClone.velocity = transform.forward * bulletspeed;
                
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            Fire();

    }


}