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
        int Object = 8;

        int randomChange = Random.Range(1, 3);

        if (lastPlayerLocation == null)
        {
            
            lastPlayerLocation = new GameObject().transform;
        }

        lastPlayerLocation.position = playerPosition.position;

        
        if(randomChange == 2)
        {
            Instantiate(Abilitie3, transform.position, Quaternion.identity);
        }


        for (var i = 0; i < Object; i++)
        {

                // Calculate a random distance between 0 and 5
                float distance = Random.Range(1f, 15f);

                // Calculate a random angle in radians
                float angle = Random.Range(0.2f, 8f * Mathf.PI);

                // Calculate the position offset based on polar coordinates
                Vector3 offset = new Vector3(Mathf.Cos(angle) * distance, 0f, Mathf.Sin(angle) * distance);


                Instantiate(warningSign, lastPlayerLocation.position + offset, Quaternion.identity); //projectiles are inside the warning script

               
         
        }


        Behave = 0;

    }

    public void secondSpell() // Spawn  enemies.
    {
       
       
            Instantiate(EnemyPrefab, spawnLocations[0].position , Quaternion.identity);

            Instantiate(EnemyPrefab, spawnLocations[1].position, Quaternion.identity);
        

        Behave = 0;

    }

     public void thirdSpell()
    {
        

        for(int i = 0; i < 3; i++)
        {

            Instantiate(Abilitie3, transform.position, Quaternion.identity);
            //should fire 3 times with a delay between shoots, for now shoot just 1
           
        }

        Behave = 0;

    }
     
    


    public void CheckStateV2()
    {

        
        int randomNumber = Random.Range(1, 4);

        isZero = true;

        Behave = randomNumber;

        StartCoroutine(untilWhen2());
        
        
    }



    IEnumerator untilWhen2()
    {
        yield return new WaitForSeconds(3);

        isZero = false;

        // Debug.Log("initiat");

    }

}


