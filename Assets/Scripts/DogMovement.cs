using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class DogMovement : MonoBehaviour
{
    public Transform playerObj;

    protected NavMeshAgent dogMesh;
    
    // Start is called before the first frame update
    void Start()
    {
        dogMesh = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        dogMesh.SetDestination(playerObj.position);
    }
}
