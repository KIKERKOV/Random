using System.Collections.Generic;
using UnityEngine;

public class SymbolGeneration : MonoBehaviour
{
    public GameObject Rock;
    public GameObject Paper;
    public GameObject Scissors;

    List<GameObject> gameObjects;
    public void PlayerChoice()
    {
        foreach (var go in gameObjects)
            go.SetActive(false);
        var randomElement = Random.Range(0, gameObjects.Count);
        gameObjects[randomElement].SetActive(true);
    }



    // Start is called before the first frame update
    void Start()
    {
        var rockClone = GameObject.Instantiate(Rock, new Vector3(0f, 0f, 0f), new Quaternion());
        var paperClone = GameObject.Instantiate(Paper, new Vector3(1.5f, 0f, 0f), new Quaternion());
        var scissorsClone = GameObject.Instantiate(Scissors, new Vector3(-1.5f, 0f, 0f), new Quaternion());

        rockClone.SetActive(false);
        paperClone.SetActive(false);
        scissorsClone.SetActive(false);

        gameObjects = new List<GameObject>();
        gameObjects.Add(rockClone);
        gameObjects.Add(paperClone);
        gameObjects.Add(scissorsClone);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
