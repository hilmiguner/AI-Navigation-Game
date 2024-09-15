using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCollision : MonoBehaviour
{
    private TargetHealth targetHealth;
    // Start is called before the first frame update
    void Start()
    {
        targetHealth = gameObject.GetComponent<TargetHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            targetHealth.GetDamage(other.gameObject.GetComponent<EnemyDamage>().damage);
            Destroy(other.gameObject);
        } 
    }
}
