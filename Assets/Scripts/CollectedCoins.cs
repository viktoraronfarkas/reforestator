using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedCoins : MonoBehaviour
{
    
    // Global Variables 
    
    // Number of collected diamonds 
    public int NumOfDiamonds { get; private set; }
    // Start is called before the first frame update

    public void DiamondCollected()
    {
        NumOfDiamonds++;
    }
}
