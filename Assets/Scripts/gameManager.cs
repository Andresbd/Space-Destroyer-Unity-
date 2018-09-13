using System;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

enum Levels {One, Two, Three};

public class gameManager : MonoBehaviour {

    public static int scoreMultiply;
    public saveData saveData;
    public static GameObject inGame;
    private static string saveName = "save.json";

	void Awake () {

        DontDestroyOnLoad(gameObject);
	    LoadGameData();
	}

    public static void Finish()
    {
        saveData save = new saveData();
        string saveState = Path.Combine(Application.persistentDataPath, "save.json");
        File.WriteAllText(saveState, JsonUtility.ToJson(save, true));
        SceneManager.LoadScene("LevelSelect");
        
        player.charHealth = 6;
        player.charShield = 0 + Upgrade.mSH;
        Level1.eneCount = 0;
    }

    public static void setMultiply(Enum e)
    {
        if (e.Equals(Levels.One))
        {
            scoreMultiply = Multiplicador.one;
        }
    }

    public static void EndGame()
    {
        SaveProgress();
        
        SceneManager.LoadScene("LevelSelect");
        
        player.charHealth = 6;
        player.charShield = 0 + Upgrade.mSH;
        Level1.eneCount = 0;
    }

    private static void SaveProgress()
    {
        saveData save = new saveData();
        
        string saveState = Path.Combine(Application.persistentDataPath, saveName);

        if (File.Exists(saveState))
        {
            string dataJson = File.ReadAllText(saveState);
        }
        else
        {
            File.WriteAllText(saveState, JsonUtility.ToJson(save, true));   
        }
    }

    private static void LoadGameData()
    {
        string saveState = Path.Combine(Application.persistentDataPath, saveName);
        
        if (File.Exists(saveState))
        {
            string dataJson = File.ReadAllText(saveState);
            saveData loadData = JsonUtility.FromJson<saveData>(dataJson);
        }
        else
        {
           Debug.LogError("No Save File");   
        }
    }
}
