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


[RequireComponent(typeof(BoxCollider))]
[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]
public class AnimalHandler : MonoBehaviour
{
    private BoxCollider boxCollider;
    private GameObject player;
    public AnimalType animalType;
    UnityEngine.AI.NavMeshAgent nav;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
        boxCollider = GetComponent<BoxCollider>();
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
        nav.SetDestination(player.transform.position); //make path towards player
        transform.LookAt(player.transform); //rotate so you look at the player
    }


    public void Sleep()
    {
        // Play Sleep anim
        gameObject.layer = LayerMask.NameToLayer("Ghost");
        boxCollider.enabled = false;
        this.gameObject.SetActive(false);
    }
}