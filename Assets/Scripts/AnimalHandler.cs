using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum AnimalType
{
    CHICKEN,
    BULL,
    COW,
    GOAT,
    PIG
}


public class AnimalHandler : MonoBehaviour
{
    public GameObject player;
    public AnimalType animalType;
    UnityEngine.AI.NavMeshAgent nav;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }


    public void Move()
    {
        if (animalType == AnimalType.CHICKEN)
        {
            Charge();
        }

        if (animalType == AnimalType.BULL)
        {
            Charge();
        }
    }

    public void Charge()
    {
        Debug.Log(player.transform.position);
        nav.SetDestination(player.transform.position); //make path towards player
        transform.LookAt(player.transform); //rotate so you look at the player
    }
}