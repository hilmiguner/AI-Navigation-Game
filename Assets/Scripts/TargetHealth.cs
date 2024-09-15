using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHealth : MonoBehaviour
{
    public int health = 100;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Current HP: " + health.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetDamage(int damage)
    {
        health -= damage;
        Debug.Log("Current HP: " + health.ToString());
        if(health <= 0) Debug.Log("Target died");
    }
}
