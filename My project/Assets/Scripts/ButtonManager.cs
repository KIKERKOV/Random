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

}
