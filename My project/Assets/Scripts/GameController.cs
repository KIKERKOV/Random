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
    public string gameOutcome = "";
    public GameObject Timer;
    [SerializeField] private GameObject PlayerBackground;
    [SerializeField] private GameObject EnemyBackground;
    [SerializeField] private Text timerText;
 
    private int CooldownTimer = 10;
 
    private void Start()
    {
        Debug.Log("Start");
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            StopAllCoroutines();
            StartCoroutine(Countdown(CooldownTimer));
            CooldownTimer -= 1;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _enemyRock.SetActive(true);
            _enemyPaper.SetActive(false);
            _enemyScissors.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            _enemyRock.SetActive(false);
            _enemyPaper.SetActive(true);
            _enemyScissors.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            _enemyRock.SetActive(false);
            _enemyPaper.SetActive(false);
            _enemyScissors.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

        }

    }


    IEnumerator Countdown(int startNumber)
    {
        int counter = startNumber;
        while (counter > 0)
        {
            timerText.text = counter.ToString();
            counter--;
            yield return new WaitForSeconds(1);
        }
        timerText.text = "0";
        //TODO: Logic when timer expires
    }
}