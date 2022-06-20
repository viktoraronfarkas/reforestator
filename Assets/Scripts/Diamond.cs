using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    [SerializeField] private Vector3 rotationAngle;
    [SerializeField] private float rotationSpeed;
    

    
     void Update()
    {
        transform.Rotate(rotationAngle * rotationSpeed * Time.deltaTime);
    }
     
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
