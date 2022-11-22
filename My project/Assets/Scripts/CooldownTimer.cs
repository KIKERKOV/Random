using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CooldownTimer : MonoBehaviour

{
    public double _cooldownTimer;
    public double _cooldownTime;

    private GameObject _gameOutcomeReached;

    private void CoolDownTimer()
    {
        if (_gameOutcomeReached == true)
        {
            _cooldownTimer = _cooldownTime;

            for (float i = 0; _cooldownTimer > 0; i++)
            {
                if (_cooldownTimer > 0)
                {
                    _cooldownTimer -= Time.deltaTime;
                }

                if (_cooldownTimer < 0)
                {
                    _cooldownTimer = 0;
                }

                float _timeIncrement = 0.5f;

                if (_cooldownTime == 0)
                {
                    i = i + _timeIncrement + i;
                }
            }
        }
    }

}


//{
//    if (_gameOutcomeReached == true && _enemyChoice < 0 && _playerChoice < 0)
//    {
//        int _iterationVersion = 0;
//        _cooldownTimer = _cooldownTime;
//        _timer.SetActive(true);
//        cooldownTimerText.text = _cooldownTimerText;
//        _cooldownTimerText = "";
//        for (int i = 0; _cooldownTime < 0; i++)
//        {
//            if (_cooldownTimer > 0)
//            {
//                _cooldownTimer -= Time.deltaTime;
//            }
//            if (_cooldownTimer < 0)
//            {
//                _cooldownTimer = 0;
//            }
//            if (_enemyChoice > 0 && _playerChoice > 0)
//            {
//                _cooldownTime = _cooldownTimer;
//                bool _isTimeRunning = true;
//                for (float j = 0; j > 10; j++)
//                {
//                    float _timeIncrement = -0.5f;
//                    if (_enemyChoice < 0 && _playerChoice < 0 && _isTimeRunning == true)
//                    {
//                        _cooldownTimer = _cooldownTime + _timeIncrement;
//                        _isTimeRunning = false;
//                        _iterationVersion++;
//                        j++;
//                    }
//                }
//            }
//        }
//    }
//}



//private void CoolDownTimer()
//{
//    if (_gameOutcomeReached == true && _enemyChoice < 0 && _playerChoice < 0)
//    {
//        int _iterationVersion = 0;
//        _cooldownTimer = _cooldownTime;
//        _timer.SetActive(true);
//        cooldownTimerText.text = _cooldownTimerText;
//        _cooldownTimerText = "";
//        for (int i = 0; _cooldownTime < 0 ; i++)
//        {
//            if (_cooldownTimer > 0)
//            {
//                _cooldownTimer -= Time.deltaTime;
//            }
//            if (_cooldownTimer < 0)
//            {
//                _cooldownTimer = 0;
//            }
//            if (_enemyChoice > 0 && _playerChoice > 0)
//            {
//                _cooldownTime = _cooldownTimer;
//                bool _isTimeRunning = true;
//                for (float j = 0; j > 10 ;j++)
//                {
//                    float _timeIncrement = -0.5f;
//                    if (_enemyChoice < 0 && _playerChoice < 0 && _isTimeRunning == true)
//                    {
//                        _cooldownTimer = _cooldownTime + _timeIncrement;
//                        _isTimeRunning = false;
//                        _iterationVersion++;
//                        j++;
//                    }
//                }
//            }
//        }
//    }
//}    


/*private void CooldownTimer()
{
    if (_gameOutcomeReached == true)
    {
        _cooldownTimer = _cooldownTime;

        for (float i = 0; _cooldownTimer > 0; i++)
        {
            if (_cooldownTimer > 0)
            {
                _cooldownTimer -= Time.deltaTime;
            }

            if (_cooldownTimer < 0)
            {
                _cooldownTimer = 0;
            }

            float _timeIncrement = 0.5f;

            if (_cooldownTime == 0)
            {
                i = i + _timeIncrement + i;
            }
        }

        //show and start timer 
        // timer will be set to 5 seconds 
        //every time player gives an input reset timer with 

    }
    //If both players have chosen a symbol 
    //Start timer
    //If the timer is started and players change their choice
    //Reset timer with less T based on the time it was reset 
    //Once the timer reaches zero display score outcome 
}*/
