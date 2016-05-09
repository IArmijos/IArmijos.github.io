using UnityEngine;
using System.Collections;

public class HUDText : MonoBehaviour {
	public GameObject scoreText;
	public GameObject timerText;
	public GameObject healthText;
	public GameObject ammoText;

	float timeLeft = 300.0f;

	int playerScore = 0;
	int playerHealth = 100;
	int playerAmmo = 12;

	// Use this for initialization - used to set the score found in the player's camera. The 3D Text must be used as a child to
	// the player character.
	void Start () {
		scoreText.GetComponent<TextMesh> ().color = Color.white;
		scoreText.GetComponent<TextMesh> ().text = "Score: " + playerScore;
		timerText.GetComponent<TextMesh> ().color = Color.white;
		timerText.GetComponent<TextMesh> ().text = "Timer: " + timeLeft;
		healthText.GetComponent<TextMesh> ().color = Color.white;
		healthText.GetComponent<TextMesh> ().text = "Health: " + playerHealth;
		ammoText.GetComponent<TextMesh> ().color = Color.white;
		ammoText.GetComponent<TextMesh> ().text = "Ammo: " + playerAmmo;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
