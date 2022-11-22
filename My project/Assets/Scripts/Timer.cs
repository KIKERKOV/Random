using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour

{
    public float CooldownTime { get => _cooldownTime; set => _cooldownTime = value; }
    public bool cooldownTimerActive = true;
    private float _cooldownTimer = 10.0f;
    private float _cooldownTime;
    [SerializeField] private Text _timer;
    [SerializeField] private float _incrementedTime = -0.5f;

    private void CoolDownTimer()

    {
        if (Input.anyKey && cooldownTimerActive == true) 
        {
            _cooldownTimer = CooldownTime;
            RandomizeColor();
            if (_cooldownTimer > 0)
            {
                _cooldownTimer -= Time.deltaTime;
            }
            if (_cooldownTimer < 0)
            {
                _cooldownTimer = 0;
            }
            for (float i = 0; _cooldownTimer > 0; i++)
            {
                float _timeIncrement = 0.5f;
                if (CooldownTime == 0)
                {
                    i = i + _timeIncrement + i;
                }
            }
        }
    }

    private void RandomizeColor()
    {
        _timer.text = ("T: " + _cooldownTimer);
        Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
        _timer.color = newColor;
    }

    void Update()
    {
        CoolDownTimer();      
    }



}

