using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehaviour : MonoBehaviour
{

    public int Behave = 0;   // if 0 do nothing   1 - basic attack   2 - spell fire from above, 3 - shot directly 10 fireballs


    void Start()
    {

    }

    void Update()
    {

    }

    public void Check()
    {
        // Checks if there is no other spell activated, if not check the conditions and turn to the right case.

        switch (Behave)
        {

            case 0:
                // do nothing
                break;

            case 1:
                // attack
                break;

            case 2:
                // spell 
                break;

            case 3:
                // spell2
                break;

            default:
                //StayDefault
                break;
        }


    }

    public void Spell()
    {
        // Activate the spell 
    }

}

