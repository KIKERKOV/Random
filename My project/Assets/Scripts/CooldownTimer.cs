using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CooldownTimer : MonoBehaviour

{
    public bool cooldownTimerActive = true;
    public float cooldownTime { get => _cooldownTime; set => _cooldownTime = value; }
    private float _cooldownTimer = 10.0f;
    private float _cooldownTime;
    private float _cooldownIncrement;
    [SerializeField] private float _incrementedTime = -0.5f;


    private void CoolDownTimer()

    {
        //when does it activate
        if (Input.anyKey && cooldownTimerActive == true) 
        {
            _cooldownTimer = cooldownTime;
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

                if (cooldownTime == 0)
                {
                    i = i + _timeIncrement + i;
                }
            }
        }
    }

    void Update()
    {
        CoolDownTimer();
    }



}

