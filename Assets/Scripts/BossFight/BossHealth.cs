using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{

    public float Health = 1000;
  

    void Start()
    {
        
    }


    void Update()
    {
     whenDie();
    }

    public void whenDie()
    {
        if (Health <= 0)
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
                Health -= player.bulletDamage;
            }
        }
    }
}
