using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantedAreaCollision : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Enemy")
        {
            gameObject.SetActive(false);
            Debug.Log("planted area collision");
        }
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
