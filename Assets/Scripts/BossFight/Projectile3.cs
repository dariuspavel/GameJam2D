using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile3 : MonoBehaviour
{
    public Transform playerPosition;

    public float forceApplied = 10f;

    private Rigidbody2D rb;



    void Start()
    {

        playerPosition = GameObject.FindGameObjectWithTag("Player").transform;

        rb = GetComponent<Rigidbody2D>();


        Vector3 direction = (playerPosition.position - transform.position).normalized;

        // Debug.Log("Force Direction: " + direction + ", Force Magnitude: " + forceApplied);

        rb.AddForce(direction * forceApplied, ForceMode2D.Impulse);
    }
}


