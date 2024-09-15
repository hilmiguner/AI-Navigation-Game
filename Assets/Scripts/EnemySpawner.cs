using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public int enemyCount;
    public GameObject enemyPrefab;
    private float time, interval;
    // Start is called before the first frame update
    void Start()
    {
        time = 0f;
        interval = Random.Range(3f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyCount >= 0)
        {
            time += Time.deltaTime;
            if(time >= interval) 
            {
                SpawnEnemy();
                time = 0f;
                interval = Random.Range(3f, 5f);
            }
        }
    }

    public void SpawnEnemy()
    {
        enemyCount--;
        if(enemyCount >= 0) Instantiate(enemyPrefab, gameObject.transform.position, Quaternion.identity);
        else Debug.Log("Enemy count is below zero.");
    }
}
