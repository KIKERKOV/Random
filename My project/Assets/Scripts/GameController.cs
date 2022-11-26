using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public bool EnablePlayerInput = true;
    public GameObject _enemyRock;
    public GameObject _enemyPaper;
    public GameObject _enemyScissors;
    public GameObject _playerRock;
    public GameObject _playerPaper;
    public GameObject _playerScissors;
    public Text gameOutcomeText;
    public string _playerTwoChoiceText;
    public string _playerOneChoiceText;
    public string gameOutcome = "";
    public GameObject Timer;
    [SerializeField] private GameObject PlayerBackground;
    [SerializeField] private GameObject EnemyBackground;
    public float CooldownTime = 0f;
    [SerializeField] private float cooldownStartValue = 10f;
    public float _timeIncrementIncrease = 0f;
    private bool cooldownTimerIsNotRunning = true;
    [SerializeField] private Text timerText;
    private int _playerOneChoice = 0;
    private int _playerTwoChoice = 0;
    [SerializeField] private int _combatPhase = 0;
    private float _transparencyFactor = 0f;
    //private float _maxTransparency = 1.0f;
    private float _minTransparency = 0.2f;


    // WORK AREA

    // WORK AREA






    private void ResetGame()
    {
        CooldownTime = 10f;
        _timeIncrementIncrease = 0f;
        _playerOneChoice = 0;
        _playerTwoChoice = 0;
        timerText.text = string.Empty;
        gameOutcomeText.text = string.Empty;
        EnablePlayerInput = true;
    }




    private void Combat()
    {
        switch (_combatPhase)
        {
            case 0:
                CombatPhase0();
                break;
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
        }

    }

    private void CombatPhase0()
    {
        if (_playerOneChoice > 0 && _playerTwoChoice >0)
        {
            StartTimer();
        }
    }



    //Utilities

    void Update()
    {
        Combat();
        RandomizeColor();
        PlayerSymbolsInput();
        GameOutcome();
    }


    //KAKO DA GO REFAKTORIRAM PODOBRO OVOJ DEL?
    private void GameOutcome()
    {
        if (_playerTwoChoice == 1 && _playerOneChoice == 1 && CooldownTime == 0)
        {
            Draw();
        }
        else if (_playerTwoChoice == 1 && _playerOneChoice == 2 && CooldownTime == 0)
        {
            PlayerWins();
        }
        else if (_playerTwoChoice == 1 && _playerOneChoice == 3 && CooldownTime == 0)
        {
            EnemyWins();
        }
        else if (_playerTwoChoice == 2 && _playerOneChoice == 1 && CooldownTime == 0)
        {
            EnemyWins();
        }
        else if (_playerTwoChoice == 2 && _playerOneChoice == 2 && CooldownTime == 0)
        {
            Draw();
        }
        else if (_playerTwoChoice == 2 && _playerOneChoice == 3 && CooldownTime == 0)
        {
            PlayerWins();
        }
        else if (_playerTwoChoice == 3 && _playerOneChoice == 1 && CooldownTime == 0)
        {
            PlayerWins();
        }
        else if (_playerTwoChoice == 3 && _playerOneChoice == 2 && CooldownTime == 0)
        {
            EnemyWins();
        }
        else if (_playerTwoChoice == 3 && _playerOneChoice == 3 && CooldownTime == 0)
        {
            Draw();
        }
    }

    private void EnemyWins()
    {
        gameOutcomeText.text = gameOutcome;
        gameOutcome = "White Wins";
        timerText.text = string.Empty;
        EnablePlayerInput = false;
    }

    private void PlayerWins()
    {
        gameOutcomeText.text = gameOutcome;
        gameOutcome = "Black Wins";
        timerText.text = string.Empty;
        EnablePlayerInput = false;
    }

    private void Draw()
    {
        gameOutcomeText.text = gameOutcome;
        gameOutcome = "Draw";
        timerText.text = string.Empty;
        EnablePlayerInput = false;
    }

    // INPUT

    private void PlayerSymbolsInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ResetGame();
        }

        if (EnablePlayerInput == true)
        {
            PlayerOneChoice();
            PlayerTwoChoice();
            if (Input.GetKeyDown(KeyCode.Q))
            {
                ResetTimer();
                _playerOneChoice = 1;
                _playerOneChoiceText = "Rock";

            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                ResetTimer();
                _playerOneChoice = 2;
                _playerOneChoiceText = "Paper";

            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                ResetTimer();
                _playerOneChoice = 3;
                _playerOneChoiceText = "Scissors";

            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                ResetTimer();
                _playerTwoChoice = 1;
                _playerTwoChoiceText = "Rock";
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                ResetTimer();
                _playerTwoChoice = 2;
                _playerTwoChoiceText = "Paper";
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                ResetTimer();
                _playerTwoChoice = 3;
                _playerTwoChoiceText = "Scissors";
            }
        }
    }


    private void PlayerOneChoice()
    {
        switch (_playerOneChoice)
        {
            case 0:
                _playerOneChoice = 0;
                _playerRock.SetActive(!true);
                _playerPaper.SetActive(!true);
                _playerScissors.SetActive(!true);
                break;
            case 1:
                _playerOneChoice = 1;
                _playerRock.SetActive(true);
                _playerPaper.SetActive(!true);
                _playerScissors.SetActive(!true);
                break;
            case 2:
                _playerOneChoice = 2;
                _playerRock.SetActive(!true);
                _playerPaper.SetActive(true);
                _playerScissors.SetActive(!true);
                break;
            case 3:
                _playerOneChoice = 3;
                _playerRock.SetActive(!true);
                _playerPaper.SetActive(!true);
                _playerScissors.SetActive(true);
                break;
            default:
                Debug.Log("Invalid Player One Input");
                break;
        }
    }

    private void PlayerTwoChoice()
    {
        switch (_playerTwoChoice)
        {
            case 0:
                _playerTwoChoice = 0;
                _enemyRock.SetActive(!true);
                _enemyPaper.SetActive(!true);
                _enemyScissors.SetActive(!true);
                break;
            case 1:
                _playerTwoChoice = 1;
                _enemyRock.SetActive(true);
                _enemyPaper.SetActive(!true);
                _enemyScissors.SetActive(!true);
                break;
            case 2:
                _playerTwoChoice = 2;
                _enemyRock.SetActive(!true);
                _enemyPaper.SetActive(true);
                _enemyScissors.SetActive(!true);
                break;
            case 3:
                _playerTwoChoice = 3;
                _enemyRock.SetActive(!true);
                _enemyPaper.SetActive(!true);
                _enemyScissors.SetActive(true);
                break;
            default:
                Debug.Log("Invalid Player Two Input");
                break;
        }
    }


    //TIMER

    private void StartTimer()
    {
        if (CooldownTime < 0)
        {
            CooldownTime = 0;
        }
        if (_timeIncrementIncrease < -10)
        {
            _timeIncrementIncrease = 0;
        }
        if (CooldownTime > 10)
        {
            CooldownTime = 10;
        }
        if (CooldownTime > 0)
        {
            CooldownTime -= Time.deltaTime;
        }
        if (CooldownTime > 0)
        {
            ShowTimer();
        }
        while (cooldownTimerIsNotRunning)
        {
            CooldownTime = cooldownStartValue + _timeIncrementIncrease;
            cooldownTimerIsNotRunning = false;
        }
    }

    private void ResetTimer()
    {
        cooldownTimerIsNotRunning = true;
        if (_timeIncrementIncrease < (CooldownTime + _timeIncrementIncrease) && _playerOneChoice > 0 && _playerTwoChoice > 0)
        {
            _timeIncrementIncrease -= 1f;
        }
    }

    private void ShowTimer()
    {
        timerText.text = ("" + Mathf.Round(CooldownTime));
    }

    //Miscellaneous

    private void RandomizeColor()
    {
        Color newColor = new Color(Random.value, Random.value, Random.value, _transparencyFactor);

        if (Input.anyKey)
        {
            timerText.color = newColor;
            gameOutcomeText.color = newColor;
            _transparencyFactor = Random.Range(0.2f, 0.8f);

        }
        if (_transparencyFactor < 0.2f)
        {
            _transparencyFactor = _minTransparency;
        }
        if (CooldownTime == 0)
        {
            _transparencyFactor = 1.0f;
        }
    }
    

    
}