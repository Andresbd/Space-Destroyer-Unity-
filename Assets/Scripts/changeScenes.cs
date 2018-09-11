using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScenes : MonoBehaviour {

	public void changeScene () {

		SceneManager.LoadScene ("LevelSelect");
	}
}