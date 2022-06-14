using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private float spraySpeed = 1100;
    public GameObject spray; 
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Fire()
    {
        //Shoot
        GameObject tempSpray = Instantiate(spray, transform.position, transform.rotation) as GameObject;
        Rigidbody tempRigidbodySpray = tempSpray.GetComponent<Rigidbody>();
        tempRigidbodySpray.AddForce(tempRigidbodySpray.transform.forward * spraySpeed);
        Destroy(tempSpray,0.5f);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }
}
