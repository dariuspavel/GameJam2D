using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    // To be added when working on bullet animation
    // public GameObject hitEffect;

    void OnCollisionEnter2D(){
        // To be added when working on bullet animation
        // GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        // Destroy(effect, 5f);
        Destroy(gameObject);
    }

}
