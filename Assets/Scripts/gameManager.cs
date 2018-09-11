using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour {

    public Text scoreText;
    public int scoreNumber;
    public int gold;
    public int experience;

    public static gameManager GM;

	void Awake () {

        //Check if Game Manager Exists
        if (GM == null)
        {
            DontDestroyOnLoad(gameObject);
            GM = this;
        }
        else if (GM != this)
        {
            Destroy(gameObject);
        }
	}

    private void Update()
    {
        scoreText.text = "Score " + scoreNumber;
    }

    public void Finish() {

    }

    public void EndGame() {

        SceneManager.LoadScene("LevelSelect");
    }
}
