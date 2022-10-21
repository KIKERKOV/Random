using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymbolGeneration : MonoBehaviour
{
    public GameObject Rock;
    public GameObject Paper;
    public GameObject Scissors;


    public void PlayerChoice()
    {
        GameObject.Instantiate(Rock, new Vector3(0f, 0f, 0f), new Quaternion());
        GameObject.Instantiate(Paper, new Vector3(1.5f, 0f, 0f), new Quaternion());
        GameObject.Instantiate(Scissors, new Vector3(-1.5f, 0f, 0f), new Quaternion());
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
