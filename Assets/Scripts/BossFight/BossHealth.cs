using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealth : MonoBehaviour
{

    public float maxHealth = 100;
    public float currentHealth;

    public HealthSlider healthBar; 

    

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        
    }


    void Update()
    {
     whenDie();
    }

    public void whenDie()
    {
        if (currentHealth <= 0)
        {
            Debug.Log("BossDead");
            gameObject.SetActive(false);
        }
    }

    public void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("PlayerBullet"))
        {
            PlayerBullet player = coll.GetComponent<PlayerBullet>();            //access coll script named playerBullet where I have a variable BulletDamage . -= health;

            if (player != null)
            {
                // Access the BulletDamage variable and apply damage to health
                currentHealth -= player.bulletDamage;

                healthBar.SetHealth(currentHealth);
            }
        }
    }

 
}



