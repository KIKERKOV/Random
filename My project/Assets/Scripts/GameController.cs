using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject _enemyRock;
    public GameObject _enemyPaper;
    public GameObject _enemyScissors;
    public GameObject _playerRock;
    public GameObject _playerPaper;
    public GameObject _payerScissors;
    public GameObject _playerWins;
    public GameObject _playerLose;

    private int enemyAction = -1;
    private int myAction = -1;
    private string CurrentAction = "";
    public int _enemyChoice;

    public void EnemySymbolGenerate()
    {
        string generatedSymbol = "";
        int action = Random.Range(0, 3);
        if (action==0)
        {
            generatedSymbol = "Rock";
            _enemyChoice = 0;
            _enemyRock.SetActive(true);
            _enemyPaper.SetActive(false);
            _enemyScissors.SetActive(false);
        }
        else if (action==1)
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
        CurrentAction = "Enemy has chosen:"+generatedSymbol;
        Debug.Log(CurrentAction);
        Debug.Log("Generate Action!!!");
        Debug.Log("Enemy Choice:"+_enemyChoice);

    }

    public void PlayerSymbolGenerate()
    {
        int action = Random.Range(0, 3);
        if (action == 0)
        {
            _playerRock.SetActive(true);
            _playerPaper.SetActive(false);
            _payerScissors.SetActive(false);
        }
        else if (action == 1)
        {
            _playerRock.SetActive(false);
            _playerPaper.SetActive(true);
            _payerScissors.SetActive(false);
        }
        else
        {
            _playerRock.SetActive(false);
            _playerPaper.SetActive(false);
            _payerScissors.SetActive(true);
        }
        myAction = action;
    }

    public void GameOutcome()
    {

        int result = 0;

        if (result == 0)
        {
            _playerWins.SetActive(true);
        }

        //Calculate who is winner who is loser


        //Koj e pobednikot?
        //Kako da se definira koj e pobednik
        //if enemy is rock and player is paper = player wins 
        if (myAction == 1 && enemyAction ==0)
        {
            _playerWins.SetActive(true);
        }    
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
