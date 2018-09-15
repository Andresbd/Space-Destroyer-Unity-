using UnityEngine;

public class player : MonoBehaviour
{

	public static int charHealth;
    public static int charShield;
	public static int gold;
	public static int experience;

	private void Start()
	{
		charShield = Upgrade.mSH;
	}

	private void Update()
	{
		ShowShield(charShield);
		showLife(charHealth);
	}

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

	void ShowShield(int sh)
	{
		switch (sh)
		{
			case 6:
				UIManager.sSix.SetActive(true);
				UIManager.sFive.SetActive(true);
				UIManager.sFour.SetActive(true);
				UIManager.sThree.SetActive(true);
				UIManager.sTwo.SetActive(true);
				UIManager.sOne.SetActive(true);
				break;
                
			case 5:
				UIManager.sSix.SetActive(false);
				UIManager.sFive.SetActive(true);
				UIManager.sFour.SetActive(true);
				UIManager.sThree.SetActive(true);
				UIManager.sTwo.SetActive(true);
				UIManager.sOne.SetActive(true);    
				break;
			
			case 4:
				UIManager.sSix.SetActive(false);
				UIManager.sFive.SetActive(false);
				UIManager.sFour.SetActive(true);
				UIManager.sThree.SetActive(true);
				UIManager.sTwo.SetActive(true);
				UIManager.sOne.SetActive(true);    
				break;
			
			case 3:
				UIManager.sSix.SetActive(false);
				UIManager.sFive.SetActive(false);
				UIManager.sFour.SetActive(false);
				UIManager.sThree.SetActive(true);
				UIManager.sTwo.SetActive(true);
				UIManager.sOne.SetActive(true);    
				break;
			
			case 2:
				UIManager.sSix.SetActive(false);
				UIManager.sFive.SetActive(false);
				UIManager.sFour.SetActive(false);
				UIManager.sThree.SetActive(false);
				UIManager.sTwo.SetActive(true);
				UIManager.sOne.SetActive(true);    
				break;
			
			case 1:
				UIManager.sSix.SetActive(false);
				UIManager.sFive.SetActive(false);
				UIManager.sFour.SetActive(false);
				UIManager.sThree.SetActive(false);
				UIManager.sTwo.SetActive(false);
				UIManager.sOne.SetActive(true);    
				break;
			case 0:
				UIManager.sSix.SetActive(false);
				UIManager.sFive.SetActive(false);
				UIManager.sFour.SetActive(false);
				UIManager.sThree.SetActive(false);
				UIManager.sTwo.SetActive(false);
				UIManager.sOne.SetActive(false);    
				break;
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
