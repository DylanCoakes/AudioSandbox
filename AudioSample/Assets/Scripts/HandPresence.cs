using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandPresence : MonoBehaviour
{
    [SerializeField]
    InputActionReference controllerActionGrip;
    [SerializeField]
    InputActionReference controllerActionTrigger;

    private Animator handAnimator;

    private void Awake()
    {
        controllerActionGrip.action.performed += GripPress;
        controllerActionTrigger.action.performed += TriggerPress;

        handAnimator = GetComponent<Animator>();
    }

    private void TriggerPress(InputAction.CallbackContext obj)
    {
        handAnimator.SetFloat("Trigger", obj.ReadValue<float>());
    }

    private void GripPress(InputAction.CallbackContext obj)
    {
        handAnimator.SetFloat("Grip", obj.ReadValue<float>());
    }
}
