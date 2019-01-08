using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    //public GameObject currentScore;
    public Text score;
    public Text health;

    // Start is called before the first frame update

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        score.text = ScoreManager.instance.score.ToString();
        health.text = PlayerMovement.instance.health.ToString();
}


    public void GameOver()
    {
        //currentScore.SetActive(false);
        score.text = PlayerPrefs.GetInt("score").ToString();
    }
}
