using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Loading scenes when pressing buttons
public class StartButton : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Death()
    {
        SceneManager.LoadScene(2);
    }

    public void CG()
    {
        SceneManager.LoadScene(3);
    }
}