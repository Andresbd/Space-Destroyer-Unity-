using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOptions : MonoBehaviour
{

	public Sprite block, noStar, oneStar, twoStar, threeStar;

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
