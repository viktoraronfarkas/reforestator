using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTree : MonoBehaviour
{
    public GameObject[] objects;
    public int objNum;
    public int objCount = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetButtonDown("Drop"))
      {
        objNum = Random.Range(0, 6);
        objCount = 0;

        while (objCount < 6)
        {
          objects[objCount].SetActive(false);
          objCount++;
        }

        objects[objNum].SetActive(true);
      }
    }

    private void Drop()
    {

    }
}
