using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
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
    public float _timeIncrementIncrease = 0f;
    public GameObject Timer;
    [SerializeField] private GameObject PlayerBackground;
    [SerializeField] private GameObject EnemyBackground;
    [SerializeField] private float timerTextStartValue = 10f;
    [SerializeField] private Text timerText;
    public float CooldownTime;
    private int _combatPhase;
    private int _playerOneChoice = 0;
    private int _playerTwoChoice = 0;

    // WORK AREA


    
    private void Combat()
    {
        if (_playerOneChoice <= 0 && _playerTwoChoice <= 0)
        {
            _combatPhase = 0;
        }
        if (_playerOneChoice > 0 && _playerTwoChoice > 0)
        {
            _combatPhase = 1;
        }
       // SETUP START TIMER RESET HERE WITH IF


        switch (_combatPhase)
        {
            case 0:
                _combatPhase = 0;
                break;
            case 1:
                _combatPhase = 1;
                break;
            case 2:
                _combatPhase = 2;
                StartTimer();
                break;
            case 3:
                _combatPhase = 3;
                ResetWorseTimer();
                break;
        }

    }


    private void StartTimer()
    {

        timerText.text = ("T: " + CooldownTime);
        if (CooldownTime > 0)
        {
            CooldownTime -= Time.deltaTime;
        }
        if (CooldownTime < 0)
        {
            CooldownTime = 0f;
        }
    }

    private void ResetWorseTimer()
    {
        for (float i = 1; CooldownTime + _timeIncrementIncrease > 0; i++)
        {
            _timeIncrementIncrease += -1f;
            i++;
            
        }
    }


    // WORK AREA

    //Utilities

    void Start()
    {
        CooldownTime += timerTextStartValue;
    }

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
        if (_playerTwoChoice == 1 && _playerOneChoice == 1)
        {
            Draw();
        }
        else if (_playerTwoChoice == 1 && _playerOneChoice == 2)
        {
            PlayerWins();
        }
        else if (_playerTwoChoice == 1 && _playerOneChoice == 3)
        {
            EnemyWins();
        }
        else if (_playerTwoChoice == 2 && _playerOneChoice == 1)
        {
            EnemyWins();
        }
        else if (_playerTwoChoice == 2 && _playerOneChoice == 2)
        {
            Draw();
        }
        else if (_playerTwoChoice == 2 && _playerOneChoice == 3)
        {
            PlayerWins();
        }
        else if (_playerTwoChoice == 3 && _playerOneChoice == 1)
        {
            PlayerWins();
        }
        else if (_playerTwoChoice == 3 && _playerOneChoice == 2)
        {
            EnemyWins();
        }
        else if (_playerTwoChoice == 3 && _playerOneChoice == 3)
        {
            Draw();
        }
        if (_playerOneChoice > 0 && _playerTwoChoice > 0)
        {
            gameOutcomeText.text = gameOutcome;
            RandomizeColor();
        }
    }

    private void EnemyWins()
    {
        gameOutcome = "Black wins";
    }

    private void PlayerWins()
    {
        gameOutcome = "White wins";
    }

    private void Draw()
    {
        gameOutcome = "Draw";
    }

    private void PlayerSymbolsInput()
    {
        PlayerOneChoice();
        PlayerTwoChoice();
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _playerOneChoice = 1;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            _playerOneChoice = 2;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            _playerOneChoice = 3;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _playerTwoChoice = 1;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _playerTwoChoice = 2;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _playerTwoChoice = 3;
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


    //Miscellaneous

    private void RandomizeColor()
    {
        Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
        if (Input.anyKey)
        {
            timerText.color = newColor;
            gameOutcomeText.color = newColor;
        }
    }
    

    
}