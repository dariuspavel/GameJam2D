using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageProperty : MonoBehaviour
{

    [SerializeField] float health, maxHealth = 3f;


    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takeDamage(float damageAmount)
    {
        health -= damageAmount;
        if(health<=0)
        {
            Destroy(gameObject);
        }
    }
}
