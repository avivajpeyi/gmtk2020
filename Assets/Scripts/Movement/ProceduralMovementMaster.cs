using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine;
using System.Collections;


public class ProceduralMovementMaster : MonoBehaviour
{

    Transform player;
    public float playerHealth;
    public float enemyHealth;
    UnityEngine.AI.NavMeshAgent nav;

        // Enemy movement

    public void Moveset_identifier()
    {   
        // if (enemytype=='Bull'){
        ChargingBullMovement Moveset; //CHECK
        Moveset = this.gameObject.AddComponent<ChargingBullMovement>();
        //}
        Moveset.Move();
    }


    public virtual void Move()
    {
        // this is what does the moving
    }

    



//    Transform player;
//    public float playerHealth;
//    public float enemyHealth;
//    UnityEngine.AI.NavMeshAgent nav;
//
//    void Awake()
//    {
//        // references
//        player = GameObject.FindGameObjectWithTag("Player").transform;
//        playerHealth = 1;
//        enemyHealth = 1;
//        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
//    }

//    public virtual void Move()
//    {
//        // Do nothing if I am ded
//        if (enemyHealth < 0)
//            return; 
//
//    }



}
