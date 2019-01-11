using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UITextUpdate : MonoBehaviour {

    public static int score;
    private TextMeshProUGUI textMesH;
    public GameObject CG;


	void Start () {
        textMesH = GetComponent<TextMeshProUGUI> ();
        score = 0;

	}

    // after picking 6 lemons wild congratulations scene appears
    void Update() {
        textMesH.text = score.ToString() + "/6";
        
        if (score >= 6)
        {
            SceneManager.LoadScene(3);

        }

	}
}
