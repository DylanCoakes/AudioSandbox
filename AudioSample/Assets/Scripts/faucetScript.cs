using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faucetScript : MonoBehaviour
{
    public float waterFlow;
    public Transform water;
    public void StartWater()
    {
        // call ac coroutine to spawn droplets
        StartCoroutine(MyCoroutine(water)); 

        IEnumerator MyCoroutine(Transform target)
        {
            while (Vector3.Distance(transform.position, target.position) > 0.5f)
            {
                transform.position = Vector3.Lerp(transform.position, water.position, waterFlow * Time.deltaTime);
            }

            yield return null;
        }
    }
}

