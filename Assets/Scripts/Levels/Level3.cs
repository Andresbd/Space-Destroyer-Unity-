using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3 : MonoBehaviour {

	public static float HighScore;
	private float tmp;
	private int _enemyPick, _spawning;
	public static int eneCount;
	public GameObject en1, en2, en3;
	private int NextEnemySpawnTime = 0;
	private int EnemySpawnRate = 5;
	public static bool blocked;
	
	private void Start()
	{
		_spawning = 1000;
		gameManager.setMultiply(Levels.One);
		Picker();
		NextEnemySpawnTime = (int)Time.time + EnemySpawnRate;
        
	}

	private void FinishLevel()
	{    
		float tmp;
		tmp = UIManager.scoreNumber;
		gameManager.scTemp = UIManager.scoreNumber;

		if (HighScore == 0)
		{
			HighScore = tmp;
			UIManager.scoreNumber = 0;
            
		}else if (tmp > HighScore)
		{
			HighScore = tmp;
			UIManager.scoreNumber = 0;
		}
		else
		{
			UIManager.scoreNumber = 0;
		}

		gameManager.lvlPass = true;
	}

	private void Picker() {
		_enemyPick = UnityEngine.Random.Range(0, 3);

		switch (_enemyPick) {
			case 0:
				spawnEnemy(en1);
				break;
			case 1:
				spawnEnemy(en2);
				break;
			case 2:
				spawnEnemy(en3);
				break;
		}
	}

	public void spawnEnemy(GameObject enemy)
	{

		Vector2 bottom = new Vector2(10f, -4.3f);
		Vector2 top = new Vector2(10f, 4.3f);

		GameObject oneEnemy = (GameObject)Instantiate(enemy);
		oneEnemy.transform.position = new Vector2(top.x, UnityEngine.Random.Range(top.y, bottom.y));

		nextEnemy();
	}

	public void nextEnemy()
	{
		int nextTime = UnityEngine.Random.Range(_spawning, 0);
		_spawning -= 1;
	}
}
