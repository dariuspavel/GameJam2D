using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehaviour : MonoBehaviour
{

    public int Behave = 0;   // if 0 do nothing   1 - basic attack   2 - spell fire from above, 3 - shot directly 10 fireballs

    int previousBehave = 0;  // Add this variable to store the previous Behave value

    [SerializeField]
    private bool isZero = false;

    [Header("Locations")]
    public Transform playerPosition;

    private Transform lastPlayerLocation;

    public Transform[] spawnLocations;

    private Vector3 offset2;



    [Header("Objects")]
    public GameObject Abilitie0;
    public GameObject Abilitie3;

    public GameObject EnemyPrefab;

    public float forceMagnitude = 10f;

    public GameObject warningSign;


    void Start()
    {
        
    }

    void Update()
    {


        if (Behave == 0 && isZero == false) 
        {
           
            CheckStateV2();
            
        }
        else
        {
            Check();
        }


      

    }


    public void Check()
    {
        // Checks if there is no other spell activated, if not check the conditions and turn to the right case.

        previousBehave = Behave;

        

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
                thirdSpell();
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

        if (lastPlayerLocation == null)
        {
            
            lastPlayerLocation = new GameObject().transform;
        }

        lastPlayerLocation.position = playerPosition.position;

        for (int i =0; i < Object; i++)
        {

            // Calculate a random distance between 0 and 5
            float distance = Random.Range(0f, 5f);

            // Calculate a random angle in radians
            float angle = Random.Range(0f, 2f * Mathf.PI);

            // Calculate the position offset based on polar coordinates
            Vector3 offset = new Vector3(Mathf.Cos(angle) * distance, 0f, Mathf.Sin(angle) * distance);

            Instantiate(warningSign, lastPlayerLocation.position + offset, Quaternion.identity);



            //Wait for 2 seconds
            
                     

            // Spawn GameObject to deal damage

            Instantiate(Abilitie0, lastPlayerLocation.position + offset2, Quaternion.identity);




        }

        Behave = 0;

    }

    public void secondSpell() // Spawn more enemies.
    {
        int enemiesToSpawn = 1;   // they will spawn in 2 locations that means 2 x 2

        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(EnemyPrefab, spawnLocations[0].position , Quaternion.identity);

            Instantiate(EnemyPrefab, spawnLocations[1].position, Quaternion.identity);
        }

        Behave = 0;

    }
    public void thirdSpell()
    {
        int numberShoots = 0;

        if (numberShoots < 3)
        {

            Instantiate(Abilitie3, transform.position, Quaternion.identity);

            numberShoots++;
        }

        Behave = 0;

    }
     
    

    IEnumerator checkState()
    {

       

       

       
           yield return new WaitForSeconds(4f);      


    }

    public void CheckStateV2()
    {

        
        int randomNumber = Random.Range(1, 4);

        isZero = true;

        StartCoroutine(untilWhen2());

        Behave = randomNumber;
        
       


        
    }



    IEnumerator untilWhen()
    {
        yield return new WaitForSeconds(1.5f);

        


    }

    IEnumerator untilWhen2()
    {
        yield return new WaitForSeconds(6);

        isZero = false;

        Debug.Log("initiat");

    }

}


