using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Text timerText;
    private int CooldownTimer = 10;

    public void CountDownTimer()
    {
        StopAllCoroutines();
        StartCoroutine(Countdown(CooldownTimer));
        CooldownTimer -= 1;
    }


    IEnumerator Countdown(int startNumber)
    {
        int counter = startNumber;
        while (counter > 0)
        {
            timerText.text = counter.ToString();
            counter--;
            yield return new WaitForSeconds(1);
        }
        timerText.text = "0";
        //TODO: Logic when timer expires
    }
}
