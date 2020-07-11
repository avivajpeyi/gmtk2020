using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//enum AnimalType
//{
//    
//}


public class AnimalHandler : MonoBehaviour
{
//    public AnimalType type;
    
    private ProceduralMovementMaster MyMoventController;
    
    
    // Start is called before the first frame update
    void Start()
    {
//        if (type == AnimalType.CHIKCEN)
//        {
//            MyMoventController = new ChargingBullMovement();
//        }
        ProceduralMovementMaster myMovement = this.gameObject
            .AddComponent<ProceduralMovementMaster>();

            myMovement = new ChargingBullMovement();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
