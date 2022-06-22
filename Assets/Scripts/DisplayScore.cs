using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayScore : MonoBehaviour
{

    private TextMeshProUGUI scoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        // Get the text component
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateItemText(CollectedCoins collectedCoins)
    {
        // Set the text to the number of collected items
        scoreText.text = collectedCoins.NumOfFlowers.ToString();
    }

 
}
