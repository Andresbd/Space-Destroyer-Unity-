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
    private [] data;

	void Awake () {

        DontDestroyOnLoad(gameObject);
	    LoadGameData();
	}
    
    public RoundData GetCurrentRoundData()
    {
        // If we wanted to return different rounds, we could do that here
        // We could store an int representing the current round index in PlayerProgress

        return data[0];
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

            // Retrieve the allRoundData property of loadedData
            allRoundData = loadedData.allRoundData;
        }
        else
        {
            Debug.LogError("Cannot load game data!");
        }
    }
}
