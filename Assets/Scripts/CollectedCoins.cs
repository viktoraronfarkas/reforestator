using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollectedCoins : MonoBehaviour
{
    
    // Global Variables 
    
    // Number of collected diamonds 
    public int NumOfDiamonds { get; private set; }

    public UnityEvent<CollectedCoins> onItemCollected;
    // Start is called before the first frame update

    public void DiamondCollected()
    {
        NumOfDiamonds++;
        onItemCollected.Invoke(this);
    }
}
