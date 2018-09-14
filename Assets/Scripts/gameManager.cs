using System;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

enum Levels {One, Two, Three};

public class gameManager : MonoBehaviour {

    public static int scoreMultiply;
    private saveData saveData;
    public static GameObject inGame;
    private string saveName = "save.json";
    public static Enum Level { get; set; }
    public static gameManager GM;

    public static bool pDead = false, lvlPass = false;

    private 

	void Start () {

        if (GM == null)
        {
            DontDestroyOnLoad(gameObject);
            GM = this;
        }else if (GM != this)
        {
            Destroy(gameObject);
        }
        
	    LoadGameData();
	}

    private void Update()
    {
        if (pDead)
        {
            EndGame();
            pDead = false;
        }

        if (lvlPass)
        {
            EndGame();
            lvlPass = false;
        }
    }

    public static void setMultiply(Enum e)
    {
        if (e.Equals(Levels.One))
        {
            Level = e;
            scoreMultiply = Multiplicador.one;
        }
    }

    public void EndGame()
    {
        SaveProgress();
        
        SceneManager.LoadScene("LevelSelect");
        
        player.charHealth = 6;
        player.charShield = 0 + Upgrade.mSH;
        
        resetEnemies();
        
    }

    private static void resetEnemies()
    {
        Level1.eneCount = 0;
    }

    public static void addKill()
    {
        if (Level.Equals(Levels.One))
        {
            Level1.eneCount += 1;
        }
        
        if (Level.Equals(Levels.Two))
        {
            
        }
        
        if (Level.Equals(Levels.Three))
        {
            
        }
    }

    private void SaveProgress()
    {
        saveData sD = new saveData();

        sD.gold = player.gold;
        sD.Attack = Upgrade.mAT;
        sD.Shield = Upgrade.mSH;
        sD.LevelOneHS = Level1.HighScore;
        
        string dataJson = JsonUtility.ToJson(sD);
        string saveState = Path.Combine(Application.persistentDataPath, saveName);

        File.WriteAllText(saveState, dataJson);
    }

    private void LoadGameData()
    {
        string filePath = Path.Combine(Application.persistentDataPath, saveName);
        
        if (File.Exists(filePath))
        {
            string dataJson = File.ReadAllText(filePath);
            
            saveData loadData = JsonUtility.FromJson<saveData>(dataJson);

            player.gold = loadData.gold;
            player.experience = loadData.exp;
            Upgrade.mAT = loadData.Attack;
            Upgrade.mSH = loadData.Shield;
        }
        else
        {
           Debug.LogError("No Save File");   
        }
    }
}
