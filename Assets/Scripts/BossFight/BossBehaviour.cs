using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehaviour : MonoBehaviour
{

    public int Behave = 0;   // if 0 do nothing   1 - basic attack   2 - spell fire from above, 3 - shot directly 10 fireballs


    [Header("Locations")]
    public Transform playerPosition;

    public Transform[] spawnLocations;



    [Header("Objects")]
    public GameObject Abilitie0;

    public GameObject EnemyPrefab;


    void Start()
    {
        // maybe run animation? 
    }

    void Update()
    {
        Check();
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
                firstSpell();
                break;

            case 2:
                secondSpell();
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

    public void firstSpell()
    {
        int Object = 5;

        for(int i =0; i < Object; i++)
        {

            // Calculate a random distance between 0 and 5
            float distance = Random.Range(0f, 5f);

            // Calculate a random angle in radians
            float angle = Random.Range(0f, 2f * Mathf.PI);

            // Calculate the position offset based on polar coordinates
            Vector3 offset = new Vector3(Mathf.Cos(angle) * distance, 0f, Mathf.Sin(angle) * distance);

            // Spawn a new GameObject around the player
            Instantiate(Abilitie0, playerPosition.position + offset, Quaternion.identity);

            

        }

        Behave = 0;
    }

    public void secondSpell() // Spawn more enemies.
    {
        int enemiesToSpawn = 2;   // they will spawn in 2 locations that means 2 x 2

        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(EnemyPrefab, spawnLocations[0].position , Quaternion.identity);

            Instantiate(EnemyPrefab, spawnLocations[1].position, Quaternion.identity);
        }

        Behave = 0;

    }
    public void thirdSpell() // Spawn more enemies.
    {
        //shoot qucik 3 projectiles that one destroyed shoot more projectiles out of them.
    }

    public void checkState()
    {

        // check if the fight has started and if current state = 0
        //  IEnumerate SecondsUntilAttack()   
        // Change the behave depending on the situation or randomise it.
    }

}


