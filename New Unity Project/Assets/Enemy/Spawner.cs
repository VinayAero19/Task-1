using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] spawners;
    public GameObject enemy;
    void Start()
    {
        spawners = new GameObject[5];
        for(int i =0;i<spawners.Length;i++)
        {
            spawners[i] = transform.GetChild(i).gameObject;
        }
    }

    
    void Update()
    {
        if(Input.GetKey(KeyCode.T))
        {
            spawnEnemy();
        }
    }
    private void spawnEnemy()
    {
        int spawnerId = Random.Range(0, spawners.Length);
        Instantiate(enemy, spawners[spawnerId].transform.position, spawners[spawnerId].transform.rotation);
    }
}
