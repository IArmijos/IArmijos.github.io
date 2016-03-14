using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class first : MonoBehaviour {

	public GameObject mainText;

	// Use this for initialization
	void Start () {
		mainText.GetComponent<TextMesh> ().color = Color.cyan;
		mainText.GetComponent<TextMesh> ().text = "The Usual Boring Day... \n \n Press Space to Play";
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("space")) {
			mainText.GetComponent<TextMesh> ().color = Color.white;
			mainText.GetComponent<TextMesh> ().text = "Good day! After taking an intense lecture in Hostos Community \t\nCollege, you decided to return home. You're standing in front \nof your house." +
			"You take a good look around your house and see \n" +
			"your surroundings. \n \n Press the I Key for information.";
		}
		if (Input.GetKeyDown (KeyCode.I)) {
			mainText.GetComponent<TextMesh> ().color = Color.white;
			mainText.GetComponent<TextMesh> ().text = "\n Press the q, w, e, a, s, and d keys to look around";
		} 
		if (Input.GetKeyDown (KeyCode.Q)) {
			mainText.GetComponent<TextMesh> ().color = Color.yellow;
			mainText.GetComponent<TextMesh> ().text = "It's a tree. What a surprise.";
		}
		if (Input.GetKeyDown (KeyCode.W)) {
			mainText.GetComponent<TextMesh> ().color = Color.yellow;
			mainText.GetComponent<TextMesh> ().text = "The roof looks normal.";
		}
		if (Input.GetKeyDown (KeyCode.E)) {
			mainText.GetComponent<TextMesh> ().color = Color.yellow;
			mainText.GetComponent<TextMesh> ().text = "It's a door. So what?";
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			mainText.GetComponent<TextMesh> ().color = Color.yellow;
			mainText.GetComponent<TextMesh> ().text = "The day is quite beautiful.";
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			mainText.GetComponent<TextMesh> ().color = Color.yellow;
			mainText.GetComponent<TextMesh> ().text = "The windows are normal";
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			mainText.GetComponent<TextMesh> ().color = Color.yellow;
			mainText.GetComponent<TextMesh> ().text = "The fences are clean.";
		} 
	}	
}
