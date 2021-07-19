using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOversceneController : MonoBehaviour
{
    public GameObject Gameover;
    public void restart()
    {
        SceneManager.LoadScene(0);
    }
    public void Menu()
    {
        SceneManager.LoadScene(2);
    }
}
