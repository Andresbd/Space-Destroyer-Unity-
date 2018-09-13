using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
	
	public Text scoreText;
	private static float scoreNumber;
	public static GameObject six, five, four, three, two, one;


	void Awake ()
	{
		six = transform.Find("Health_bar/6hp").gameObject;
		five = transform.Find("Health_bar/5hp").gameObject;
		four = transform.Find("Health_bar/4hp").gameObject;
		three = transform.Find("Health_bar/3hp").gameObject;
		two = transform.Find("Health_bar/2hp").gameObject;
		one = transform.Find("Health_bar/1hp").gameObject;
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
