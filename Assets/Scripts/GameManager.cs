using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public bool gameOver;
   

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void StartGame()
    {

        SceneManager.LoadScene(1);
        
       
    }

    public void GameOver()
    {
        
        gameOver = true;
        UIManager.instance.GameOver();
        SceneManager.LoadScene("Game");
        

    }
}

