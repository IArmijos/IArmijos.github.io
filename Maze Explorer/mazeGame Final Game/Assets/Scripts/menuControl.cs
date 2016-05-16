using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;
using System.Collections;

public class menuControl : MonoBehaviour {

	public Button startButton;
	public Button exitButton;

	// Use this for initialization
	void Start () {
		startButton = startButton.GetComponent<Button> ();
		exitButton = exitButton.GetComponent<Button> ();
	}

	// This code is used to confirm that the start button is not active while the exit button is exit
	public void ExitPress() {
		startButton.enabled = false;
		exitButton.enabled = true;
	}

	// This code is used to confirm that both the start and exit buttons in the menu screen isn't activated since none of them are being clicked on.
	public void NoPress() {
		startButton.enabled = false;
		exitButton.enabled = false;
	}

	// This code is used to load the leve if and only if the start game button text is used.
	public void StartLevel(){
		//SceneManager.LoadScene ("PrototypeA");
		Application.LoadLevel ("PrototypeA");
	}

	// This code is used to confirm that pressing the exit button will cause the game to close (WON'T work on Web Player version of game!!!)
	public void ExitGame(){
		Application.Quit ();
	}
}

//References
//https://www.youtube.com/watch?v=pT4uca2bSgc