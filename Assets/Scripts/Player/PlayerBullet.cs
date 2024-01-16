using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    // To be added when working on bullet animation
    // public GameObject hitEffect;
    private float bulletDamage = 1f;

    void OnCollisionEnter2D(Collision2D collision){
        // To be added when working on bullet animation
        // GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        // Destroy(effect, 5f);
        Destroy(gameObject);
        if (collision.gameObject.CompareTag("Enemy")) 
        { 
            EnemyDamageProperty enemy = collision.transform.GetComponent<EnemyDamageProperty>();
            if (enemy != null) {
                enemy.takeDamage(bulletDamage);
            }
        } 
            
            
        }
}
