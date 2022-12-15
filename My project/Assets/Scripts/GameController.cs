using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private Combat _combat;
    private Scissors _scissors;

    void Start()
    {
        _scissors = GameObject.Find("Scissors").GetComponent<Scissors>();
        _combat = GameObject.Find("Combat").GetComponent<Combat>();
        if (_scissors == null)
        {
            Debug.LogWarning("Scissors is NULL");
        }
        if (_combat == null)
        {
            Debug.LogWarning("Combat is NULL");
        }
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Q))
        {
            _combat.Scissors();
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
}