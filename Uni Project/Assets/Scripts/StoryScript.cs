using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryScript : MonoBehaviour {

    public GameObject text;

//When pressing "start" game is pause until we click left mouse button
	
	void Start ()
    {
        Time.timeScale = 0;
        
	}
	
	
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            text.SetActive(false);
            Time.timeScale = 1;
        }
	}
}
