using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        CollectedCoins collectedCoins = other.GetComponent<CollectedCoins>();

        if (collectedCoins != null)
        {
            collectedCoins.DiamondCollected();
            gameObject.SetActive(false);
        }
    }
}
