using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootSpeed : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]
    float speed;
    [SerializeField]
    float lifeSpan;
    public GameObject bulletPrefab;
    private Transform gun;
    // Start is called before the first frame update
    void Start()
    {//determines how fast the bullet moves
        gun = GameObject.Find("Gun").transform;
       rb = GetComponent<Rigidbody>();
     rb.AddForce(-gun.right * (speed), ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {// allows me to determine the time the bullet span lasts.
        if (lifeSpan >= 0)
        {
            lifeSpan -= Time.deltaTime;
        }
        else//destroy water
        {
            Destroy  (bulletPrefab);
        }
    }
}
