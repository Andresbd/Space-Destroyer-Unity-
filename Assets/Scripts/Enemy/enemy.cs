using UnityEngine;

public class enemy : MonoBehaviour {
	
	private int scoreValue = 5;
	private int goldValue = 1;
	private int Health = 5;
	private int ht;
	
	private void Start()
	{
		ht = bullet.damage + Upgrade.mAT;
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		//all projectile colliding game objects should be tagged "Enemy" or whatever in inspector but that tag must be reflected in the below if conditional
		if(col.tag == "Bullet")
		{
			Damage ();
			UIManager.moreScore(scoreValue * gameManager.scoreMultiply);
		}

		if(col.tag == "Player")
		{
			Destroy (gameObject);
		}
	}

	void Damage () {
		
		Health -= ht;

		if (Health <= 0) {

			Level1.eneCount += 1;
			player.gold = player.gold + goldValue;
			Destroy (gameObject);
		}
	}
}
