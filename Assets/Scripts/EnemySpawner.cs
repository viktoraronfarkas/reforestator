using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField] private GameObject swarmerEnemy;
    
    
    // Number of seconds until a new enemy appear
    [SerializeField] private float swarmerInterval = 10f;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spwanEnemy(swarmerInterval, swarmerEnemy));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator spwanEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        
        // Create the enemies , enemies should appear from random positionsTimerLogic
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5f), Random.Range(-6f, 6f), 0),Quaternion.identity);
        
        // Generate enemies endlessly 
        StartCoroutine(spwanEnemy(interval, enemy));

    }
}
