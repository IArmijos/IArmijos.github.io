//Israel's second Text Adventure game
using UnityEngine;
using System.Collections;

public class firstBehavior : MonoBehaviour {

	public GameObject textThing;

	int roomX = 0;
	int roomY = 0;

	bool hasKey = false;

	// Use this for initialization
	void Start () {
		hasKey = false;
		textThing.GetComponent<TextMesh> ().text = "Maze Rage!  \n \nPress Space to Play!";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			textThing.GetComponent<TextMesh> ().color = Color.white;
			textThing.GetComponent<TextMesh> ().text = "Good morning. You've been summoned to the maze, my friend. \nYou don't know why you're here but you do \nknow one thing; you wanna GO HOME!!!\nPress I for controls";
		}
		if (Input.GetKeyDown (KeyCode.I)) {
			textThing.GetComponent<TextMesh> ().color = Color.white;
			textThing.GetComponent<TextMesh> ().text = "Press up, down, left, and right to navigate. Now play.\nYou're in room " + roomX + roomY;
		}
		if (Input.GetKeyDown ("up")) {
			textThing.GetComponent<TextMesh> ().color = Color.white;
			textThing.GetComponent<TextMesh> ().text = "You've decided to go forward. What's your next move? \nYou're in room " + roomX + roomY;

			roomY++;
		}
		if (Input.GetKeyDown ("down")) {
			textThing.GetComponent<TextMesh> ().color = Color.white;
			textThing.GetComponent<TextMesh> ().text = "You've decided to go back. What's your next move? \nYou're in room " + roomX + roomY;

			roomY--;
		}
		if (Input.GetKeyDown ("left")) {
			textThing.GetComponent<TextMesh> ().color = Color.white;
			textThing.GetComponent<TextMesh> ().text = "You've decided to go left. What's your next move? \nYou're in room " + roomX + roomY;
			
			roomX--;
		}
		if (Input.GetKeyDown ("right")) {
			textThing.GetComponent<TextMesh> ().color = Color.white;
			textThing.GetComponent<TextMesh> ().text = "You've decided to go right. What's your next move? \nYou're in room " + roomX + roomY;
			
			roomX++;
		}
		/*Paths you can't navigate*/
		if (roomY < 0) {
			textThing.GetComponent<TextMesh> ().color = Color.white;
			textThing.GetComponent<TextMesh> ().text = "You can't go there!";
			roomY = 0;
		}
		if (roomY == 7) {
			textThing.GetComponent<TextMesh> ().color = Color.white;
			textThing.GetComponent<TextMesh> ().text = "You can't go there!";
			roomY = 6;
		}
		if (roomX < 0) {
			textThing.GetComponent<TextMesh> ().color = Color.white;
			textThing.GetComponent<TextMesh> ().text = "You can't go there!";
			roomX = 0;
		}
		if (roomX == 7) {
			textThing.GetComponent<TextMesh> ().color = Color.white;
			textThing.GetComponent<TextMesh> ().text = "You can't go there!";
			roomX = 6;
		}
		/*Unnavigating paths ended */

		/*Reset game*/
		if (Input.GetKeyDown (KeyCode.R)) {
			textThing.GetComponent<TextMesh> ().color = Color.white;
			textThing.GetComponent<TextMesh> ().text = "Welcome back! You know what to do!";

			roomX = 0;
			roomY = 0;

			if (hasKey == true) {
				hasKey = false;
			}
		}
		/*Reset game code over*/

		/*rooms of interest*/
		if (roomX == 5 && roomY == 3) {
			textThing.GetComponent<TextMesh> ().color = Color.white;
			textThing.GetComponent<TextMesh> ().text = "Hmm...there's a nice wind going around here...";
		}
		if (roomX == 1 && roomY == 0) {
			textThing.GetComponent<TextMesh> ().color = Color.white;
			textThing.GetComponent<TextMesh> ().text = "You see an old man here. He begs for you to help \nhis lucky gold coin in exchange of a way home.\nYou're in room "+ roomX + roomY;
		}
		if (roomX == 5 && roomY == 2) {
			textThing.GetComponent<TextMesh> ().color = Color.white;
			textThing.GetComponent<TextMesh> ().text = "You have a really bad feeling about this. Might I \n suggest turning back now? \nYou're in room " + roomX + roomY;
		}
		if (roomX == 4 && roomY == 1) {
			textThing.GetComponent<TextMesh> ().color = Color.white;
			textThing.GetComponent<TextMesh> ().text = "You have a really bad feeling about this. Might I \n suggest turning back now? \nYou're in room " + roomX + roomY;
		}
		if (roomX == 5 && roomY == 1) {
			textThing.GetComponent<TextMesh> ().color = Color.white;
			textThing.GetComponent<TextMesh> ().text = "Oh dear... By entering the room, you'vs triggered \n a spike trap. You died a gruesome death. \nPress R to reset.";
		
		}
		if (roomX == 3 && roomY == 2) {
			textThing.GetComponent<TextMesh> ().color = Color.white;
			textThing.GetComponent<TextMesh> ().text = "Eh, don't you think you're getting a little ahead \n of yourself? \nYou're in room "+ roomX + roomY;
		}
		if (roomX == 3 && roomY == 4) {
			textThing.GetComponent<TextMesh> ().color = Color.white;
			textThing.GetComponent<TextMesh> ().text = "Eh, don't you think you're getting a little ahead \n of yourself? \nYou're in room "+ roomX + roomY;
		}
		if (roomX == 4 && roomY == 3) {
			textThing.GetComponent<TextMesh> ().color = Color.white;
			textThing.GetComponent<TextMesh> ().text = "Eh, don't you think you're getting a little ahead \n of yourself? \nYou're in room "+ roomX + roomY;
		}
		if (roomX == 3 && roomY == 3) {
			textThing.GetComponent<TextMesh> ().color = Color.white;
			textThing.GetComponent<TextMesh> ().text = "WHOA! You feel into a bottomless pit! You lost, idiot. \nPress R to reset.";
		}

		/*rooms of interest coding over*/

		/*Getting coin/End Game Scenario*/
		if (roomX == 6 && roomY == 4) {
			textThing.GetComponent<TextMesh> ().color = Color.white;
			textThing.GetComponent<TextMesh> ().text = "Great! You found the key! Now go back to the old man \nto seal the deal! \nYou're in room "+ roomX + roomY;

			hasKey = true;
			}

		if (roomX == 1 && roomY == 0 && hasKey == true) {
			textThing.GetComponent<TextMesh> ().color = Color.white;
			textThing.GetComponent<TextMesh> ().text = "You return where the old man was last time. You gave\nhim the coin back. He is pleased at your test so\nhe decided to give you a rocket backpack\nto help you return home. Thankful for the gift, you use it to\nleave the maze and return home safely.\n\nCongratulations. You won! Press R to play again!";
		}
		/*Getting coin/End Game Scenario Coding over*/
	}
}