using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BubbleShoot : MonoBehaviour
{
    private XRGrabInteractable grabInteractable;
    [SerializeField]
    GameObject bubblePrefab;
    [SerializeField]
    Transform spawnPoint;
    // Start is called before the first frame update
    void Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(SpawnBubbles);

    }

    private void SpawnBubbles(ActivateEventArgs arg0)
    {
        Instantiate(bubblePrefab, spawnPoint.position, Quaternion.identity);
    }
}