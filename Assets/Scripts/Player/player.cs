using UnityEngine;

public class player : MonoBehaviour {
	
	public static int charHealth;
	
    public static float charShield;
    public static float charEnergy;
	public static int gold;
	public static int experience;
	
	
	public GameObject six, five, four, three, two, one;

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
                gameManager.EndGame();
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
			case 12:
				six.SetActive(true);
				five.SetActive(true);
				four.SetActive(true);
				three.SetActive(true);
				two.SetActive(true);
				one.SetActive(true);
				break;
                
			case 10:
				six.SetActive(false);
				five.SetActive(true);
				four.SetActive(true);
				three.SetActive(true);
				two.SetActive(true);
				one.SetActive(true);    
				break;
			
			case 8:
				six.SetActive(false);
				five.SetActive(false);
				four.SetActive(true);
				three.SetActive(true);
				two.SetActive(true);
				one.SetActive(true);    
				break;
			
			case 6:
				six.SetActive(false);
				five.SetActive(false);
				four.SetActive(false);
				three.SetActive(true);
				two.SetActive(true);
				one.SetActive(true);    
				break;
			
			case 4:
				six.SetActive(false);
				five.SetActive(false);
				four.SetActive(false);
				three.SetActive(false);
				two.SetActive(true);
				one.SetActive(true);    
				break;
			
			case 2:
				six.SetActive(false);
				five.SetActive(false);
				four.SetActive(false);
				three.SetActive(false);
				two.SetActive(false);
				one.SetActive(true);    
				break;
		}
	}
}
