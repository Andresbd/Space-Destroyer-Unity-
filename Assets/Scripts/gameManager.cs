using System;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

enum Levels {One, Two, Three};

public class gameManager : MonoBehaviour {

    public static float scoreMultiply;
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
    }

    public static void setMultiply(Enum e)
    {
        if (e.Equals(Levels.One))
        {
            Debug.Log("Nivel1");
            scoreMultiply = Multiplicador.one;
        }
    }

    public static void EndGame()
    {
        saveData save = new saveData();
        
        string saveState = Path.Combine(Application.persistentDataPath, "save.json");
        File.WriteAllText(saveState, JsonUtility.ToJson(save, true));
        
        SceneManager.LoadScene("LevelSelect");
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
