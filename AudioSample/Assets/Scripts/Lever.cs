using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    private HingeJoint hinge;
    [SerializeField]
    GameObject bubbleGun;
    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if(hinge.angle == hinge.limits.min)
        {
            bubbleGun.SetActive(true);
        }
    }
}
