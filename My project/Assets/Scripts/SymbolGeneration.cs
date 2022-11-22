using System.Collections.Generic;
using UnityEngine;

public class SymbolGeneration : MonoBehaviour
{
    public GameObject[] Symbols;


    void Update()
    {
        PlayerChoice();
        EnemyChoice();
    }

    public void EnemyChoice()
    {

        if (Input.GetKeyDown(KeyCode.Q))
        {
            //Change instantiated object Active Status
        }


    }

    public void PlayerChoice()
    {

    }



    // Start is called before the first frame update
    void Start()
    {




    }

    /* var rockClone = GameObject.Instantiate(Symbols[0], new Vector3(0f, 0f, 0f), new Quaternion());
 var paperClone = GameObject.Instantiate(Symbols[1], new Vector3(1.5f, 0f, 0f), new Quaternion());
 var scissorsClone = GameObject.Instantiate(Symbols[2], new Vector3(-1.5f, 0f, 0f), new Quaternion());

 rockClone.SetActive(false);
 paperClone.SetActive(false);
 scissorsClone.SetActive(false);

 gameObjects = new List<GameObject>();
 gameObjects.Add(rockClone);
 gameObjects.Add(paperClone);
 gameObjects.Add(scissorsClone);

 EnemyChoice();
*/


    /*List<GameObject> gameObjects;
public void PlayerChoice()
{
    foreach (var go in gameObjects)
        go.SetActive(false);
    var randomElement = Random.Range(0, gameObjects.Count);
    gameObjects[randomElement].SetActive(true);
}*/

}
