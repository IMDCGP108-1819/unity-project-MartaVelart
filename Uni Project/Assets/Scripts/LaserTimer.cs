using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTimer : MonoBehaviour
{
    //3 stages of laser and their timers
    public GameObject firstLaser;
    public GameObject secondLaser;
    public GameObject thirdLaser;

    [Header("Stage 1")]
    public float endTimer1 = 5;
    [Header("Stage 2")]
    public float endTimer2 = 10;
    [Header("Stage 3")]
    public float endTimer3 = 15;



    public float timer;

    
    void Start()
    {
       
        timer = 0;

    }

   //according to selected times lasers/beams appear
    void Update()
    {
        timer += Time.deltaTime;

        if (timer <= endTimer1)
        {
            firstLaser.SetActive(true);
            secondLaser.SetActive(false);
            thirdLaser.SetActive(false);
        }
        else if (timer <= endTimer2)
        {
            firstLaser.SetActive(false);
            secondLaser.SetActive(true);
            thirdLaser.SetActive(false);
        }
        else if (timer <= endTimer3)
        {
            firstLaser.SetActive(false);
            secondLaser.SetActive(false);
            thirdLaser.SetActive(true);
           

        }
        else if (timer > endTimer3)
        {
            timer = 0f;
          
        }
    }
}