using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Test_GameController : MonoBehaviour
{
    [SerializeField] private Text timerText;
    private Scissors _p1_Symbol;
    private int CooldownTimer = 10;

    private void Start()
    {
        _p1_Symbol = GameObject.Find("P1_Symbol").GetComponent<Scissors>();
        if (_p1_Symbol == null)
        {
            Debug.LogWarning("P1_Symbol is NULL");
        }
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
            _p1_Symbol.Scissors_Animation();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {

        }
        if (Input.GetKeyDown(KeyCode.E))
        {

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