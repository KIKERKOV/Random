using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour

{
    public float CooldownTime;
    public bool StartLuckCombat = true;
    [SerializeField] private float _timerStartValue = 10f;
    [SerializeField] private Text _timer;
    private float _timeIncrement = 0;

    private void Start()
    {
        CooldownTime += _timerStartValue;
    }


    void Update()
    {
        RandomizeColor();
        StartTimer();
    }

    private void StartTimer()
    {
        _timer.text = ("T: " + CooldownTime);

        //CONDITION THAT TRIGGERS REDUCED COOLDOWN TIMER
        for (int i = 0;CooldownTime > (CooldownTime + (_timeIncrement * _timeIncrement)); i++)
        {
            CooldownTime += (_timeIncrement * _timeIncrement);
            i++;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _timeIncrement -= -0.5f;
            Debug.Log("Lowered time incrmenet");
        }

        if (CooldownTime > 0)
        {
            CooldownTime -= Time.deltaTime;
        }

        if (CooldownTime < 0)
        {
            CooldownTime = 0f;
        }
    }


    private void RandomizeColor()
    {
        if (Input.anyKey && CooldownTime > 0)
        {
            Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
            _timer.color = newColor;
        }
            
    }
}
