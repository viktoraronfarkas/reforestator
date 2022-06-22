using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class TimerLogic : MonoBehaviour
{
    [SerializeField] private Image timerFillImage;
    [SerializeField] private Text timerText;

    public bool timeIsRunning = false;

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public int Duration { get; private set; }

    private int remainingDuration;

    private void Awake()
    {
        ResetTimer();
    }

    private void ResetTimer()
    {
        timeIsRunning = false;
        timerText.text = "00:00";
        timerFillImage.fillAmount = 0f;
        Duration = remainingDuration = 0;
    }

    public TimerLogic SetDuration(int seconds)
    {
        Duration = remainingDuration = seconds;
        return this;
    }

    public void Begin()
    {

        timeIsRunning = true;
        StopAllCoroutines();
        StartCoroutine(UpdateTimer());
        
    }

    private IEnumerator UpdateTimer()
    {
        while (remainingDuration > 0)
        {
            UpdateUI(remainingDuration);
            remainingDuration--;
            yield return new WaitForSeconds(1f);
        }
        End();
    }

    private void UpdateUI(int seconds)
    {
        // Set the format of timer text
        // D2 means print 2 digits even if seconds < 10 
        timerText.text = string.Format("{0:D2}:{1:D2}", seconds / 60, seconds % 60);
        
        // Set how the timerFillImage shape
        timerFillImage.fillAmount = Mathf.InverseLerp(0, Duration, seconds);
    }

    public void End()
    {
        ResetTimer();
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

}
