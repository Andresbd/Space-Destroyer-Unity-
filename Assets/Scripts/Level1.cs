using UnityEngine;
using System.Diagnostics;

public class Level1 : MonoBehaviour {

    private int HighScore;
    private float enemyDamage = 1;
    private float goldMultiply = 1;
    private float scoreMultiply = 1;
    int time;
    int nextTime;
    private int enemyPick;

    public GameObject en1, en2, en3;
    
    int NextEnemySpawnTime = 0;
    int EnemySpawnRate = 5;

    private void Start()
    {
        Picker();
        NextEnemySpawnTime = (int)Time.time + EnemySpawnRate;
    }

    void Update()
    {
        if((int)Time.time == NextEnemySpawnTime){
 
            Picker();
            NextEnemySpawnTime = (int)Time.time + EnemySpawnRate;
        }
    }

    private void Picker() {
        enemyPick = UnityEngine.Random.Range(0, 3);

        switch (enemyPick) {
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
        nextTime = UnityEngine.Random.Range(1000, time);
    }


}
