using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOptions : MonoBehaviour {

	public void levelSelect()
	{
		SceneManager.LoadScene("LevelSelect");
	}

	public void upgradeMenu()
	{
		SceneManager.LoadScene("UpgradeMenu");
	}

	public void lvlOne()
	{
		SceneManager.LoadScene("Level1");
	}
}
