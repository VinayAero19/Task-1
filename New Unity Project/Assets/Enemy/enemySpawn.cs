using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{
    public GameObject enemy;
    public int xPos;
    public int zPos;
    public int enemyCount;

    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

     IEnumerator EnemyDrop()
    {
        while(enemyCount<1)
        {
            xPos = Random.Range(1, 10);
            zPos = Random.Range(1, 11);
            Instantiate(enemy, new Vector3(xPos, 6, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCount += 1;
        }
    }

    void Update()
    {
        
    }
}
