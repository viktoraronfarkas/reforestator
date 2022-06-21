using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantedAreaHealthBar : MonoBehaviour
{
    private HealthBar areaHealth;
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
        if (collision.transform.tag == "Enemy")
        {
            areaHealth.health -= 20;
        }
    }
}
