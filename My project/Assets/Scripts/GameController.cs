using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private Combat _combat;
    private Scissors _scissors;
    private Audio _audio;

    // To DO next - https://docs.unity.cn/2019.2/Documentation/Manual/webgl-templates.html
    // https://docs.unity3d.com/Manual/webgl-templates.html


    void Start()
    {
        _scissors = GameObject.Find("Scissors").GetComponent<Scissors>();
        _combat = GameObject.Find("Combat").GetComponent<Combat>();
        _audio = GameObject.Find("Audio").GetComponent<Audio>();
        if (_scissors == null)
        {
            Debug.LogWarning("Scissors is NULL");
        }
        if (_combat == null)
        {
            Debug.LogWarning("Combat is NULL");
        }
        if (_audio == null)
        {
            Debug.LogWarning("A udio is NULL");
        }
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Q))
        {
            _combat.Scissors();
            _audio.RickRoll();

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