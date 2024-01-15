using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyMovement : MonoBehaviour
{

    public AIPath aIPath;

    private Vector2 direction;


    // Update is called once per frame
    void Update()
    {
        // Processing Inputs
        faceVelocity();
        
    }

    void FixedUpdate()
    {
        // Physics Calculations
        
    }

    void faceVelocity()
    {
        direction = aIPath.desiredVelocity;

        transform.right = direction;
    }

    // This script will be attached to grapichs of basic enemy


}
