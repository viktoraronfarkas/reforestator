using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTree : MonoBehaviour
{
    public GameObject tree;

    public Transform player;


    void Plant(Vector3 spawnPos)
    {
        GameObject plantedTree = Instantiate(tree, spawnPos, transform.rotation) as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
      Vector3 playerPos = player.transform.position;
      Vector3 playerDirection = player.transform.forward;
      Quaternion playerRotation = player.transform.rotation;
      float spawnDistance = 3;

      Vector3 spawnPos = playerPos + playerDirection*spawnDistance;

      if (Input.GetKeyDown("e"))
      {
          Plant(spawnPos);
      }
    }
}
