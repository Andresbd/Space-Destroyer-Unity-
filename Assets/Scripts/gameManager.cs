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
        saveData save = new saveData();
        
        string saveState = Path.Combine(Application.persistentDataPath, "save.json");
        File.WriteAllText(saveState, JsonUtility.ToJson(save, true));
        
        SceneManager.LoadScene("LevelSelect");
        
        player.charHealth = 6;
        player.charShield = 0 + Upgrade.mSH;
        Level1.eneCount = 0;
    }
    
    private void LoadGameData()
    {
        string filePath = Path.Combine(Application.persistentDataPath, "save.json");

        if(File.Exists(filePath))
        {
            // Read the json from the file into a string
            string dataAsJson = File.ReadAllText(filePath); 
            // Pass the json to JsonUtility, and tell it to create a GameData object from it
            saveData loadedData = JsonUtility.FromJson<saveData>(dataAsJson);
        }
        else
        {
            Debug.LogError("Cannot load game data!");
        }
    }
}
