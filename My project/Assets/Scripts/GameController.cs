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



    public void EnemySymbolGenerate()
    {
        int action = Random.RandomRange(0, 3);
        if (action==0)
        {
            _enemyRock.active = true;
            _enemyPaper.active = false;
            _enemyScissors.active = false;
        }
        else if (action==1)
        {
            _enemyRock.active = false;
            _enemyPaper.active = true;
            _enemyScissors.active = false;
        }
        else
        {
            _enemyRock.active = false;
            _enemyPaper.active = false;
            _enemyScissors.active = true;
        }
        Debug.Log("Generate Action!!!");

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

    }

    public void Winner()
    {
   
        //Koj e pobednikot?
        //Kako da se definira koj e pobednik
        //if enemy is rock and player is paper = player wins 
 
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
