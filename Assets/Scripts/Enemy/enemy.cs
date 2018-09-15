using UnityEngine;

public class enemy : MonoBehaviour {
	
	private int scoreValue = 5;
	private int goldValue = 1;
	private int Health = 10;
	private int ht;
	
	private void Start()
	{
		ht = bullet.damage + Upgrade.mAT;
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		//If the enemy detects the trigger event of an objet with tag Bullet apply damage
		if(col.tag == "Bullet")
		{
			Damage ();
		}

		if(col.tag == "Player")
		{
			Destroy (gameObject);
		}
	}

	void Damage () {
		
		Health -= ht;

		if (Health <= 0) {

			gameManager.addKill();
			player.gold = player.gold + goldValue;
			UIManager.moreScore(scoreValue * gameManager.scoreMultiply);
			Destroy (gameObject);
		}
	}
}
