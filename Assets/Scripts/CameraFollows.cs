using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollows : MonoBehaviour
{
    // Global Variables 
    
    // The target object = Player
    public Transform targetObject;
    
    // Default distance between the cam and the player
    public Vector3 camerOffset;
    
    // Smooth factor for camera rotation : Smooth the camera movement 
    public float smoothFactor = 0.5f;
    
    // Check weather the camera looked at the player or not 
    public bool lookAtTarget = false;
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        // calculate the distane between the cam and the player
        camerOffset = transform.position - targetObject.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Calculate the new position 
        Vector3 newPosition = targetObject.transform.position + camerOffset;
        
        // Set the position of the camera to the new position
        transform.position = Vector3.Slerp(transform.position,newPosition,smoothFactor);
        
        // Camera rotation change 
        if (lookAtTarget)
        {
            transform.LookAt(targetObject);
        }

    }
}
