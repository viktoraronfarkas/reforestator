using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class EnemyRandomMovment : MonoBehaviour
{
   
    // Global Varibales 

    public float timer;

    [SerializeField] private  float newtarget;

    [SerializeField] private float speed;

    public NavMeshAgent nav;

    public Vector3 Target;
    
    
    // Start is called before the first frame update
    void Start()
    {
         // Assign NavMeshAgent 
         nav = gameObject.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= newtarget)
        {
            newTarget();
            
            // reset timer 
            timer = 0;
        }
    }

    void newTarget()
    {
        // Get x , z positions 
        float xPosition = gameObject.transform.position.x;
        float zPosition = gameObject.transform.position.z;
        
        // New x,z postions 
        float newXPosition = xPosition + Random.Range(xPosition - 50, xPosition + 50);
        float newZPosition = zPosition + Random.Range(zPosition - 50, zPosition + 50);
        
        // New Target 
        Target = new Vector3(newXPosition, gameObject.transform.position.y, newZPosition);
        
        // Where the enemy should go 
        nav.SetDestination(Target);


    }
}
