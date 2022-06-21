using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class DogMovement : MonoBehaviour
{
    public Transform playerObj;

    protected NavMeshAgent dogMesh;

    public Rigidbody rb;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        dogMesh = GetComponent<NavMeshAgent>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        dogMesh.SetDestination(playerObj.position);

        if (dogMesh.pathPending)
        {
           if (dogMesh.remainingDistance > dogMesh.stoppingDistance)
           {
               if (dogMesh.hasPath || dogMesh.velocity.sqrMagnitude != 0f)
               {
                   animator.SetBool("isWalking", true);
               }
           }
        }

        if (!dogMesh.pathPending)
        {
           if (dogMesh.remainingDistance <= dogMesh.stoppingDistance)
           {
               if (!dogMesh.hasPath || dogMesh.velocity.sqrMagnitude == 0f)
               {
                   animator.SetBool("isWalking", false);
               }
           }
        }
    }
}
