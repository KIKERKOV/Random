using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private GameObject[] objects;
    public GameObject _enemyRock;
    public GameObject _enemyPaper;
    public GameObject _enemyScissors;
    public GameObject _playerRock;
    public GameObject _playerPaper;
    public GameObject _payerScissors;
    public GameObject _playerWin;
    public GameObject _enemyWin;
    public GameObject _playerDraw;

    public Text descriptiveText;

    private int enemyAction = -1;
    private int myAction = -1;
    private string _enemyCurrentAction = "";
    private string _playerCurrentAction = "";
    public int _enemyChoice = -1;
    public int _playerChoice = -1;
    public string _enemyChoiceText;
    public string _playerChoiceText;
    public bool _gameOutcomeReached;
    public string _gameOutcome = "";
    public int _resultDraw = 0;
    public int _resultPlayerWins = 1;
    public int _resultEnemyWins = 2;


    public void LuckCombat()
    {
        EnemySymbolGenerate();
        PlayerSymbolGenerate();
    }

    private void ResetScore()
    {
        _playerChoice = -1;
        _enemyChoice = -1;
        _enemyRock.SetActive(false);
        _enemyPaper.SetActive(false);
        _enemyScissors.SetActive(false);
        _playerRock.SetActive(false);
        _playerPaper.SetActive(false);
        _payerScissors.SetActive(false);
        descriptiveText.text = string.Empty;
        _playerDraw.SetActive(false);
        _playerWin.SetActive(false);
        _enemyWin.SetActive(false);
    }
    public void EnemySymbolGenerate()
    {
        _gameOutcomeReached = false;
        string generatedSymbol = "";
        int action = Random.Range(0, 3);
        if (action == 0)
        {
            generatedSymbol = "Rock";
            _enemyChoice = 0;
            _enemyRock.SetActive(true);
            _enemyPaper.SetActive(false);
            _enemyScissors.SetActive(false);
        }
        else if (action == 1)
        {
            generatedSymbol = "Paper";
            _enemyChoice = 1;
            _enemyRock.SetActive(false);
            _enemyPaper.SetActive(true);
            _enemyScissors.SetActive(false);
        }
        else
        {
            generatedSymbol = "Scissors";
            _enemyChoice = 2;
            _enemyRock.SetActive(false);
            _enemyPaper.SetActive(false);
            _enemyScissors.SetActive(true);
        }
        enemyAction = action;
        _enemyCurrentAction = "Enemy has chosen:" + generatedSymbol;
        Debug.Log(_enemyCurrentAction);
        Debug.Log("Enemy Generated Action!!!");
        Debug.Log("Enemy Choice:" + _enemyChoice);
        _enemyChoiceText = generatedSymbol;
        GameOutcome();
    }

    public void PlayerSymbolGenerate()
    {
        _gameOutcomeReached = false;
        string generatedSymbol = "";
        int action = Random.Range(0, 3);
        if (action == 0)
        {
            generatedSymbol = "Rock";
            _playerChoice = 0;
            _playerRock.SetActive(true);
            _playerPaper.SetActive(false);
            _payerScissors.SetActive(false);
        }
        else if (action == 1)
        {
            generatedSymbol = "Paper";
            _playerChoice = 1;
            _playerRock.SetActive(false);
            _playerPaper.SetActive(true);
            _payerScissors.SetActive(false);
        }
        else
        {
            generatedSymbol = "Scissors";
            _playerChoice = 2;
            _playerRock.SetActive(false);
            _playerPaper.SetActive(false);
            _payerScissors.SetActive(true);
        }
        myAction = action;
        _playerCurrentAction = "Player has chosen:" + generatedSymbol;
        Debug.Log(_playerCurrentAction);
        Debug.Log("Player Generated Action!!!");
        Debug.Log("Player Choice:" + _playerChoice);
        _playerChoiceText = generatedSymbol;
        GameOutcome();
    }

    private void GameOutcome()
    {
        if (_enemyChoice == 0 && _playerChoice == 0 && _gameOutcomeReached == false)
            Draw();
        else if (_enemyChoice == 0 && _playerChoice == 1 && _gameOutcomeReached == false)
            PlayerWins();
        else if (_enemyChoice == 0 && _playerChoice == 2 && _gameOutcomeReached == false)
            EnemyWins();
        else if (_enemyChoice == 1 && _playerChoice == 0 && _gameOutcomeReached == false)
            EnemyWins();
        else if (_enemyChoice == 1 && _playerChoice == 1 && _gameOutcomeReached == false)
            Draw();
        else if (_enemyChoice == 1 && _playerChoice == 2 && _gameOutcomeReached == false)
            PlayerWins();
        else if (_enemyChoice == 2 && _playerChoice == 0 && _gameOutcomeReached == false)
            PlayerWins();
        else if (_enemyChoice == 2 && _playerChoice == 1 && _gameOutcomeReached == false)
            EnemyWins();
        else if (_enemyChoice == 2 && _playerChoice == 2 && _gameOutcomeReached == false)
            Draw();

        descriptiveText.text = _gameOutcome;

        if (_enemyChoice > -1 && _playerChoice > -1)
        {
           StartCoroutine(ResetGameAfter2Seconds());
        }
    }

    private void Result()
    {

    }



    private void EnemyWins()
    {
        _playerDraw.SetActive(false);
        _playerWin.SetActive(false);
        _enemyWin.SetActive(true);
        _gameOutcomeReached = true;
        _gameOutcome = "Enemy wins";
    }

    private void PlayerWins()
    {
        _playerDraw.SetActive(false);
        _playerWin.SetActive(true);
        _enemyWin.SetActive(false);
        _gameOutcomeReached = true;
        _gameOutcome = "Player wins";
    }

    private void Draw()
    {
        _playerDraw.SetActive(true);
        _playerWin.SetActive(false);
        _enemyWin.SetActive(false);
        _gameOutcomeReached = true;
        _gameOutcome = "The game is a draw";
    }

    private IEnumerator ResetGameAfter2Seconds()
    {
        yield return new WaitForSeconds(2.0f);
        ResetScore();
    }

    // Start is called before the first frame update
    void Start()
    {
        objects = new GameObject[3];

        ResetScore();
    }

    // Update is called once per frame
    void Update()
    {


    }
}