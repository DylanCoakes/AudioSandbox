using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;

public class ShootBubblesStudent : MonoBehaviour
{
    private XRGrabInteractable grabInteractable = null;
    [SerializeField]
    GameObject bubblePrefab;
    [SerializeField]
    Transform spawnPoint;
    private int bubbleAmmo = 10;
    [SerializeField]
    private TextMeshProUGUI ammoText;
    // Start is called before the first frame update
    void Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(SpawnBubbles);
    }


    private void SpawnBubbles(ActivateEventArgs arg0)
    {
        if  (bubbleAmmo > 0)
        {//spawn bubble when trigger is pressed
            Instantiate(bubblePrefab, spawnPoint.transform.position, Quaternion.identity);
            //-1 bubble everytime trigger is pressed
            bubbleAmmo--;
            ammoText.text = bubbleAmmo.ToString();
        }
        
    }
}
