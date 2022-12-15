using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    private Timer _timer;
    private Scissors _scissors;
   


    private void Start()
    {
        _scissors = GameObject.Find("Scissors").GetComponent<Scissors>();
        _timer = GameObject.Find("Timer").GetComponent<Timer>();

        if (_scissors == null)
        {
            Debug.LogWarning("Scissors is NULL");
        }
        if (_timer == null)
        {
            Debug.LogWarning("Scissors is NULL");
        }
    }

    public void StartTimer()
    {
        _timer.CountDownTimer();
    }    

    public void Scissors()
    {
        _scissors.Scissors_Animation();
    }




}
