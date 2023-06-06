using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleShield : MonoBehaviour
{
    public float shieldDuration = 3f; // Duration of the shield in seconds
    public bool sheildOn = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // ActivateShield(shieldDuration);
            Invoke("ActivateShield", shieldDuration);
            Destroy(gameObject);
        }
    }
    private void ActivateShield(float shieldDuration)
    {
        sheildOn = !sheildOn;
    }

}
