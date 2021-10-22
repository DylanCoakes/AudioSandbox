using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutinesExample : MonoBehaviour
{
    public HingeJoint hinge;
    public GameObject water;
    public GameObject waterFlow;
    public float min;

    void waterSpawn()
    {
        StartCoroutine(StartWater);
    }

    private void StartCoroutine(Func<Transform, IEnumerator> startWater)
    {
        throw new NotImplementedException();
    }

    IEnumerator StartWater(Transform target)
    {//when hinge angle is =0 instantiate
        if (hinge.angle == min)

        {//move water to waterflow spawn position.
            Instantiate(water,waterFlow.transform.position, Quaternion.identity);

           yield return null;
        }

         

        
    }
}