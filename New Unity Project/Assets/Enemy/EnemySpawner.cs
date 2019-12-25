using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject[] spawner;
    public GameObject Enemy;
    void Start()
    {
        spawner = new GameObject[5];
        for(int i = 0;i<spawner.Length; i++)
        {
            spawner[i] = transform.GetChild(i).gameObject;
        }

    
    }

    private void SpawnEnemy()
    {
        int spawnerId = Random.Range(0, spawner.Length);
        Instantiate(Enemy,spawner[spawnerId].transform.position,spawner[spawnerId].transform.rotation);
    }

    void Update()
    {
        
    }
}
