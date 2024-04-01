using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanMonster2 : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public GameObject[] spwanPoint;
    bool[] isSpwan = new bool[7];
    float lastSpwanTime = 0.0f;
    public float spwanTime = 1.0f;

    void Update()
    {
        lastSpwanTime += Time.deltaTime;
        if (lastSpwanTime >= spwanTime)
        {
            int spwanMonster = Random.Range(1, 5);
            int i = 0;
            while(i < spwanMonster)
            {
                int num = Random.Range(0, 7);
                if (isSpwan[num] == false)
                {
                    isSpwan[num] = true;
                    i++;
                }
            }
            for(int j = 0; j < spwanPoint.Length; j++)
            {
                if (spwanPoint[j])
                {
                    Instantiate(EnemyPrefab, spwanPoint[j].transform);
                }
            }
        }
    }
}
