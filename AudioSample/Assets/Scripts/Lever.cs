using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public HingeJoint hinge;
    [SerializeField]
    //faucetScript fs;
    

    
   //acessing the hinge component on the lever
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
       // fs = GameObject("waterFlow").GetComponent<faucetScript>();
    }

    //IF IT PASSES THE LIMIT, WATERFLOW IS SET TO ACTIVE
    void Update()
    {
        if (hinge.angle == hinge.limits.min)
        {
           // Start fs;
        }
    }
}
