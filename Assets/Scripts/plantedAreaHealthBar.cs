using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantedAreaHealthBar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       //Debug.Log(areaHealth.maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.GetType());
        if (collision.transform.tag == "Enemy")
        {
            GameObject go = GameObject.Find("PlantedArea");
            HealthBar areaHealth = go.GetComponent<HealthBar>();
            areaHealth.reduceHealth();
        }
    }
}
