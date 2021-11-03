using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using System;

public class LocomotionController : MonoBehaviour
{
    [SerializeField]
    GameObject baseControllerObject;
    [SerializeField]
    GameObject teleportGameObject;

    [SerializeField]
    InputActionReference teleportActivationReference;

    public UnityEvent onTeleportActivate;
    public UnityEvent onTeleportCancel;

    private void Start()
    {
        teleportActivationReference.action.performed += TeleportModeActivate;
        teleportActivationReference.action.canceled += TeleportModeCancel;
    }

    private void TeleportModeCancel(InputAction.CallbackContext obj)
    {
        Invoke("DeactivateTeleporter", 0.1f);
    }
    void DeactivateTeleporter()
    {
        onTeleportCancel.Invoke();
    }
    private void TeleportModeActivate(InputAction.CallbackContext obj)
    {
        onTeleportActivate.Invoke();
    }
}
