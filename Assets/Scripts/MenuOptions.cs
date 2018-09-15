using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuOptions : MonoBehaviour
{

	public Sprite block, noStar, oneStar, twoStar, threeStar;
	private Button lvl1, lvl2, lvl3;
	private Text goldText;
	private float goldNumber, lvl1Score, lvl2Score, lvl3Score;
	private Scene cScene;

	private void Awake()
	{
		cScene = SceneManager.GetActiveScene();
	}

	private void Start()
	{
		if (cScene.name == "LevelSelect")
		{
			lvl1 = GameObject.Find("Canvas/Level1").GetComponent<Button>();
			lvl2 = GameObject.Find("Canvas/Level2").GetComponent<Button>();
			lvl3 = GameObject.Find("Canvas/Level3").GetComponent<Button>();

			setStatus();
		}
	}

	private void Update()
	{
		if (cScene.name == "LevelSelect" || cScene.name == "UpgradeMenu")
		{
			goldText = GameObject.Find("Canvas/Gold").GetComponent<Text>();
			goldNumber = player.gold;

			if (goldText == null)
			{
				Debug.LogError("No TEXT");
			}
			else
			{
				goldText.text = "oro: " + goldNumber;
			}	
		}
	}

	void setStatus()
	{
		lvl1Score = Level1.HighScore;
		lvl2Score = Level2.HighScore;
		bool onePass = Level2.blocked;
		bool twoPass = Level3.blocked;

		if (lvl1Score == 0)
		{
			lvl1.GetComponent<Image>().sprite = noStar;
		}else if (lvl1Score > 0 && lvl1Score <= 25)
		{
			lvl1.GetComponent<Image>().sprite = oneStar;
		}else if (lvl1Score > 25 && lvl1Score <= 75)
		{
			lvl1.GetComponent<Image>().sprite = twoStar;
		}else if (lvl1Score > 75 && lvl1Score <= 100)
		{
			lvl1.GetComponent<Image>().sprite = threeStar;
		}
		
		if (lvl2Score == 0)
		{
			if (onePass)
			{
				lvl2.GetComponent<Image>().sprite = noStar;
			}else
			{
				lvl2.GetComponent<Image>().sprite = block;
			}
		}else if (lvl2Score > 0 && lvl2Score <= 25)
		{
			lvl1.GetComponent<Image>().sprite = oneStar;
		}else if (lvl2Score > 25 && lvl2Score <= 75)
		{
			lvl1.GetComponent<Image>().sprite = twoStar;
		}else if (lvl2Score > 75 && lvl2Score <= 100)
		{
			lvl1.GetComponent<Image>().sprite = threeStar;
		}
		
		if (lvl3Score == 0)
		{
			if (onePass)
			{
				lvl3.GetComponent<Image>().sprite = noStar;
			}else
			{
				lvl3.GetComponent<Image>().sprite = block;
			}
		}else if (lvl3Score > 0 && lvl2Score <= 25)
		{
			lvl1.GetComponent<Image>().sprite = oneStar;
		}else if (lvl3Score > 25 && lvl2Score <= 75)
		{
			lvl1.GetComponent<Image>().sprite = twoStar;
		}else if (lvl3Score > 75 && lvl2Score <= 100)
		{
			lvl1.GetComponent<Image>().sprite = threeStar;
		}
	}

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
