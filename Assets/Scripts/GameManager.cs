using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] enemiesDefault = new GameObject[1];
    public GameObject[] enemiesTiny = new GameObject[1];
    public GameObject[] enemiesBig = new GameObject[1];
    private readonly List<GameObject[]> enemyList = new List<GameObject[]>();
    public GameObject target;
    void Start()
    {
        enemyList.Add(enemiesDefault);
        enemyList.Add(enemiesTiny);
        enemyList.Add(enemiesBig);
        SetTargets();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetTargets()
    {
        foreach (GameObject[] enemyArr in enemyList)
        {
            foreach (GameObject enemy in enemyArr)
            {
                enemy.GetComponent<Agents>().SetTarget(target);
            }
        }
    }
}
