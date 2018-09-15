using System;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScreen : MonoBehaviour
{

	private float hs, sc;
	private Text HS, SC;
	private static Enum Current { get; set; }

	private void Start()
	{
		Current = gameManager.Level;
		HS = GameObject.Find("Canvas/HighScore").GetComponent<Text>();
		SC = GameObject.Find("Canvas/Score").GetComponent<Text>();
		sc = gameManager.scTemp;
		setScores();
	}

	public void setScores()
	{
		if (Current.Equals(Levels.One))
		{
			hs = Level1.HighScore;
			
			HS.text = ""+hs;
			SC.text = ""+sc;
		}
	}
}
