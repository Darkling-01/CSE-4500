using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void Levels()
    {
        SceneManager.LoadScene("Levels");
    }

    public void StageOne()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
