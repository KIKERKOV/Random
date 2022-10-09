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
        int action = Random.RandomRange(0, 3);
        if (action==0)
        {
            generatedSymbol = "Rock";
            _enemyChoice = 0;
            _enemyRock.active = true;
            _enemyPaper.active = false;
            _enemyScissors.active = false;
        }
        else if (action==1)
        {
            generatedSymbol = "Paper";
            _enemyChoice = 1;
            _enemyRock.active = false;
            _enemyPaper.active = true;
            _enemyScissors.active = false;
        }
        else
        {
            generatedSymbol = "Scissors";
            _enemyChoice = 2;
            _enemyRock.active = false;
            _enemyPaper.active = false;
            _enemyScissors.active = true;
        }
        enemyAction = action;
        CurrentAction = "Enemy has chosen:"+generatedSymbol;
        Debug.Log(CurrentAction);
        Debug.Log("Generate Action!!!");
        Debug.Log("Enemy Choice:"+_enemyChoice);

    }

    public void PlayerSymbolGenerate()
    {
        int action = Random.RandomRange(0, 3);
        if (action == 0)
        {
            _playerRock.active = true;
            _playerPaper.active = false;
            _payerScissors.active = false;
        }
        else if (action == 1)
        {
            _playerRock.active = false;
            _playerPaper.active = true;
            _payerScissors.active = false;
        }
        else
        {
            _playerRock.active = false;
            _playerPaper.active = false;
            _payerScissors.active = true;
        }
        myAction = action;
    }

    public void GameOutcome()
    {
        string result;

        result = "Player Wins:" + _enemyChoice;


        //Calculate who is winner who is loser
       
 
        //Koj e pobednikot?
        //Kako da se definira koj e pobednik
        //if enemy is rock and player is paper = player wins 
        if (myAction == 1 && enemyAction ==0)
        {
            _playerWins.active = true;
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
