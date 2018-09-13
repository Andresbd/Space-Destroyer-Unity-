using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldDisplay : MonoBehaviour {

	public Text goldText;
	private static float goldNumber;
	
	private void Start()
	{
		goldNumber = player.gold;
		goldText.text = "oro: " + goldNumber;
	}
}
