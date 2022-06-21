using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class SetTimer : MonoBehaviour
{
    [SerializeField] private TimerLogic timer1;
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
            timer1.SetDuration(10).Begin();
        }
    }
}
