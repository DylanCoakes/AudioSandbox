using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    private HingeJoint hinge;
    [SerializeField]
    faucetScript faucetScript;

    
   //acessing the hinge component on the lever
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
    }

    //IF IT PASSES THE LIMIT, WATERFLOW IS SET TO ACTIVE
    void Update()
    {
        if (hinge.angle == hinge.limits.min)
        {
            faucetScript.StartWater();
        }
    }
}
