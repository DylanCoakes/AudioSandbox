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
    [SerializeField]
    InputActionReference relaodAction;
    private XRBaseInteractor interactor;
    private ActionBasedController actionController;
    // Start is called before the first frame update
    void Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(SpawnBubbles);
        relaodAction.action.started += Relaod;
    }
    public void GetInteractor()
    {//getting the object the player grabs, finding out what hand it is in and populates the value
        interactor = grabInteractable.selectingInteractor;

    }
    public void ReleaseInteractor()
    {
        interactor = null;
    }
    private void Relaod(InputAction.CallbackContext obj)
    {//when using the secondary button, does it match the controller in the hand and then do something
        if (obj.control.ToString().Contains("Left") && interactor.name.Contains("Left"))
        {
            bubbleAmmo = 10;
            ammoText.text = bubbleAmmo.ToString();
        }
        else if (obj.control.ToString().Contains("Right") && interactor.name.Contains("Right"))
        {
            bubbleAmmo = 10;
            ammoText.text = bubbleAmmo.ToString();
        }
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
