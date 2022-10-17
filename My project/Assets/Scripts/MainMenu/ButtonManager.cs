using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    public void StartGame()
    {
        Debug.Log("I was clicked");
        SceneManager.LoadScene("LuckCombat", LoadSceneMode.Single);
    }

    public void ExitGame()
    {
        Application.Quit();
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
