using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject EnemyPrefab;
    //float lastSpawnTime = 0.0f;
    //float SpawnTime = 1.0f;

    public List<GameObject> spawnPoints;

    bool enableSpawn = true;

    void SpawnEnemy()
    {
        if (enableSpawn)
        {
            int[] spawnNum = new int[3];
            int i = 0;
            while(i < spawnNum.Length)
            {
                bool check = true;
                int randIndex = Random.Range(0, 5);
                for(int j = 0; j < i; j++)
                {
                    if (spawnNum[j] == randIndex)
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                {
                    spawnNum[i] = randIndex;
                    i++;
                }
            }

            for(int j = 0; j<spawnNum.Length;j++)
            {
                Instantiate(EnemyPrefab,spawnPoints[spawnNum[j]].transform.position, Quaternion.identity);
            } 
        }
    }

    private void Start()
    {
        InvokeRepeating("SpawnEnemy", 0.5f, 2.0f);
    }

    void Update()
    {
        //lastSpawnTime += Time.deltaTime;
        //if (lastSpawnTime >= SpawnTime)
        //{
        //    float spwanX = Random.Range(-2.5f, 2.5f);

        //    Instantiate(EnemyPrefab, new Vector3(spwanX, transform.position.y, 0), Quaternion.identity);
        //    lastSpawnTime = 0;
        //}
    }
}
