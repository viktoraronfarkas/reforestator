using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class SetTimer : MonoBehaviour
{
    [SerializeField] private TimerLogic timer1;
    
    //[SerializeField] private float 
    // Start is called before the first frame update
    void Start()
    {
        timer1.SetDuration(60).Begin();

    }

    // Update is called once per frame
    void Update()
    {
        if (timer1.timeIsRunning == false)
        {
            timer1.SetDuration(60).Begin();
        }
    }
}
