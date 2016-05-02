using UnityEngine;
using System.Collections;

public class HUDText : MonoBehaviour {
	public GameObject scoreText;

	int playerScore = 0;

	// Use this for initialization - used to set the score found in the player's camera. The 3D Text must be used as a child to
	// the player character.
	void Start () {
		scoreText.GetComponent<TextMesh> ().color = Color.white;
		scoreText.GetComponent<TextMesh> ().text = "Score Counter " + playerScore;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
