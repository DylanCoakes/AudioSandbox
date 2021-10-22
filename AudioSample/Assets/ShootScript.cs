using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ShootScript : MonoBehaviour
{
    [SerializeField]
    GameObject bulletPrefab;
    private XRGrabInteractable grabInteractable;
    [SerializeField]
    GameObject spawnPoint;
    // Start is called before the first frame update
    void Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(FireBullet);
    }

    // Update is called once per frame
    private void FireBullet(ActivateEventArgs arg0)

    {
        Instantiate(bulletPrefab, spawnPoint.transform.position, Quaternion.identity);
    }
}
