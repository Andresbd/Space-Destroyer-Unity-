using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
	
	public Text scoreText;
	private static float scoreNumber;

	void Awake () {

		player.charHealth = 12;
		player.charShield = 6;
	}
	
	void Update()
	{
		scoreText.text = "Score " + scoreNumber;
	}

	public static void moreScore(int ammount)
	{
		scoreNumber = scoreNumber + (ammount*gameManager.scoreMultiply);
	}
}
