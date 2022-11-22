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
    public GameObject _playerWin;
    public GameObject _enemyWin;
    public GameObject _playerDraw;
    public Text descriptiveText;
    public int _enemyChoice = -1;
    public int _playerChoice = -1;
    public string _enemyChoiceText;
    public string _playerChoiceText;
    public bool _gameOutcomeReached;
    public string _gameOutcome = "";
    [SerializeField] private GameObject PlayerBackground;
    [SerializeField] private GameObject EnemyBackground;

    void Start()
    {
        ResetScore();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && _enemyChoice < 0)
        {
            _enemyRock.SetActive(true);
            _enemyChoice = 0;

        }
        else if (Input.GetKeyDown(KeyCode.W) && _enemyChoice < 0)
        {
            _enemyPaper.SetActive(true);
            _enemyChoice = 1;
        }
        else if (Input.GetKeyDown(KeyCode.E) && _enemyChoice < 0)
        {
            _enemyScissors.SetActive(true);
            _enemyChoice = 2;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && _playerChoice < 0)
        {
            _playerRock.SetActive(true);
            _playerChoice = 0;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && _playerChoice < 0)
        {
            _playerPaper.SetActive(true);
            _playerChoice = 1;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && _playerChoice < 0)
        {
            _playerScissors.SetActive(true);
            _playerChoice = 2;
        }

        if (_gameOutcomeReached == false)
        {
            GameOutcome();
        }
    }

    public void LuckCombat()
    {
        _enemyChoice = Random.Range(0, 2);
        _playerChoice = Random.Range(0, 2);
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
        _playerScissors.SetActive(false);
        descriptiveText.text = string.Empty;
        _playerDraw.SetActive(false);
        _playerWin.SetActive(false);
        _enemyWin.SetActive(false);
        _gameOutcomeReached = false;
        _gameOutcome = string.Empty;
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
        Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
        descriptiveText.color = newColor;

        if (_enemyChoice > -1 && _playerChoice > -1 && _gameOutcomeReached == true)
        {
            StartCoroutine(ResetGameAfter2Seconds());
        }
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

}