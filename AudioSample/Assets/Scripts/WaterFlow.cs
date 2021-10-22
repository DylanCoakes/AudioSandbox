using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFlow : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]
    float speed;
    [SerializeField]
    float lifeSpan;
    // Start is called before the first frame update
    void Start()
    {
      //  rb = GetComponent<Rigidbody>();
        //rb.AddForce(Vector3.forward * (speed / 2), ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {// allows me to determine the time the water life span lasts.
        if (lifeSpan >= 0)
        {
            lifeSpan -= Time.deltaTime;
        }
        else//destroy water
        {
            Destroy(gameObject);
        }
    }
}
