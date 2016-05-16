using UnityEngine;
using System.Collections;

public class HUDText : MonoBehaviour {

	public GameObject timerText;
	public GameObject healthText;
	public GameObject ammoText;

	float timeLeft = 6000.0f;

	int playerHealth = 100;
	int playerAmmo = 12;

	// Use this for initialization - used to set the score found in the player's camera. The 3D Text must be used as a child to
	// the player character.
	void Start () {
		timerText.GetComponent<TextMesh> ().color = Color.white; // Sets up the color for the timer Text
		timerText.GetComponent<TextMesh> ().text = "Timer: " + timeLeft; //Sets up the variables for the game's Timer 
		healthText.GetComponent<TextMesh> ().color = Color.white; // Sets up the color for the timer Text
		healthText.GetComponent<TextMesh> ().text = "Health: " + playerHealth;
		ammoText.GetComponent<TextMesh> ().color = Color.white;
		ammoText.GetComponent<TextMesh> ().text = "Ammo: " + playerAmmo;
	}
	
	// Update is called once per frame
	void Update () {
		// 

	
		timerText.GetComponent<TextMesh> ().color = Color.white;
		timerText.GetComponent<TextMesh> ().text = "Timer: " + timeLeft;
		timeLeft = timeLeft - 1;
		if (timeLeft == 0) {
			Application.LoadLevel ("gameOver");
		}
	
	}
}
