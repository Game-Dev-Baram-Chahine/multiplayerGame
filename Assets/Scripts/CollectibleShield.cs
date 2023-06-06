using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleShield : MonoBehaviour
{
    public float shieldDuration = 3f; // Duration of the shield in seconds
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (other.gameObject.TryGetComponent<Health>(out var health))
            {
                Debug.Log("Dealing damage");
                health.ActivateShield(shieldDuration);
                Destroy(gameObject);
            }

        }
    }


}
