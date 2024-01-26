using System.Collections;
using System.Collections.Generic;
using Pathfinding;
using UnityEngine;

public class SetEnemeyTarget : MonoBehaviour
{
    
    [SerializeField] public AIDestinationSetter AIDestinationSetter;

    public GameObject target;
    // Start is called before the first frame update
    void Awake()
    {
        ZombieTargetsPlayer();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void ZombieTargetsPlayer()
    {

       
        target = GameObject.FindGameObjectWithTag("Player");

        //AIDestinationSetter.target = target.transform;

        gameObject.GetComponent<AIDestinationSetter>().target = target.transform;
    }
}
