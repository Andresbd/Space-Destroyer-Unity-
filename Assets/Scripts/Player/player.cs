using UnityEngine;

public class player : MonoBehaviour
{

	public static int charHealth = 6;
    public static float charShield = 0;
	public static int gold;
	public static int experience;

	void OnTriggerEnter2D(Collider2D col)
	{
		//all projectile colliding game objects should be tagged "Enemy" or whatever in inspector but that tag must be reflected in the below if conditional
		if(col.tag == "Enemy" || col.tag == "Meteor")
		{
			Damage ();
		}
	}

	void Damage () {

        if (charShield <= 0) {

            charHealth = charHealth - 1;
	        showLife(charHealth);

            if (charHealth <= 0)
            {
	            gameManager.pDead = true;
                Destroy(gameObject);
            }
        }
		else
		{
			charShield -= 1;
		}
	}
	
	public void showLife(int hp)
	{
		switch (hp)
		{
			case 6:
				UIManager.six.SetActive(true);
				UIManager.five.SetActive(true);
				UIManager.four.SetActive(true);
				UIManager.three.SetActive(true);
				UIManager.two.SetActive(true);
				UIManager.one.SetActive(true);
				break;
                
			case 5:
				UIManager.six.SetActive(false);
				UIManager.five.SetActive(true);
				UIManager.four.SetActive(true);
				UIManager.three.SetActive(true);
				UIManager.two.SetActive(true);
				UIManager.one.SetActive(true);    
				break;
			
			case 4:
				UIManager.six.SetActive(false);
				UIManager.five.SetActive(false);
				UIManager.four.SetActive(true);
				UIManager.three.SetActive(true);
				UIManager.two.SetActive(true);
				UIManager.one.SetActive(true);    
				break;
			
			case 3:
				UIManager.six.SetActive(false);
				UIManager.five.SetActive(false);
				UIManager.four.SetActive(false);
				UIManager.three.SetActive(true);
				UIManager.two.SetActive(true);
				UIManager.one.SetActive(true);    
				break;
			
			case 2:
				UIManager.six.SetActive(false);
				UIManager.five.SetActive(false);
				UIManager.four.SetActive(false);
				UIManager.three.SetActive(false);
				UIManager.two.SetActive(true);
				UIManager.one.SetActive(true);    
				break;
			
			case 1:
				UIManager.six.SetActive(false);
				UIManager.five.SetActive(false);
				UIManager.four.SetActive(false);
				UIManager.three.SetActive(false);
				UIManager.two.SetActive(false);
				UIManager.one.SetActive(true);    
				break;
		}
	}
}
