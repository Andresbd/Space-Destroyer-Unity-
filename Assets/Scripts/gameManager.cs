using System;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

enum Levels {One, Two, Three};

public class gameManager : MonoBehaviour {

    public static int scoreMultiply;
    public static float scTemp;
    
    private saveData saveData;
    public static GameObject inGame;
    private string saveName = "save.json";
    public static Enum Level { get; set; }
    public static gameManager GM;

    public static bool pDead = false, lvlPass = false;

	void Start () {
        
	    //Check if a Game Manager exists
        if (GM == null)
        {
            DontDestroyOnLoad(gameObject);
            GM = this;
        }else if (GM != this)
        {
            Destroy(gameObject);
        }
        
	    //Load saved process via JSON
	    LoadGameData();
	}

    private void Update()
    {
        //Check two conditions, if player passed the level or player died
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

    //Check the current level and add a Score Multiplier
    public static void setMultiply(Enum e)
    {
        if (e.Equals(Levels.One))
        {
            Level = e;
            scoreMultiply = Multiplicador.one;
        }else if (e.Equals(Levels.Two))
        {
            Level = e;
            scoreMultiply = Multiplicador.two;
        }
    }

    //State if player died or player passed de level
    public void EndGame()
    {
        SaveProgress();
        SceneManager.LoadScene("ScoreScreen");
        
        //Reset player data and add it's upgrades
        player.charHealth = 6;
        player.charShield = Upgrade.mSH;
        
        //Reset enemies from all levels
        resetEnemies();
        
    }

    //Set the Enemy Count to 0 in every level
    private static void resetEnemies()
    {
        Level1.eneCount = 0;
        Level2.eneCount = 0;
    }

    //If player killed a enemy, add one to the Enemy Counter of each level
    public static void addKill()
    {
        //At the beginning of the level, the level tells the game manager which level is it via ENUM
        if (Level.Equals(Levels.One))
        {
            Level1.eneCount += 1;
        }
        
        if (Level.Equals(Levels.Two))
        {
            Level2.eneCount += 1;
        }
    }

    //Save current state of progress via JSON
    private void SaveProgress()
    {
        //Create a new Save data
        saveData sD = new saveData();

        //Assign current status to that saved data
        sD.gold = player.gold;
        sD.Attack = Upgrade.mAT;
        sD.Shield = Upgrade.mSH;
        sD.LevelOneHS = Level1.HighScore;
        
        //Parse it to JSON
        string dataJson = JsonUtility.ToJson(sD);
        string saveState = Path.Combine(Application.persistentDataPath, saveName);

        //Write file
        File.WriteAllText(saveState, dataJson);
    }

    //Load current data from saved data
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

            player.charHealth = 6;
            player.charShield = Upgrade.mSH;
        }
        else
        {
           Debug.LogError("No Save File");   
        }
    }
}
