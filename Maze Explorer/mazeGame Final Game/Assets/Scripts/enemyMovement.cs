using UnityEngine;
using System.Collections;

public class enemyMovement : MonoBehaviour {

	public GameObject player;
	public GameObject killer;
	public GameObject healthText;
	public Vector3 destination;

	int playerHealth = 3;

	// Use this for initialization
	void Start () {
		destination = player.transform.position; //This code will cause the enemy to try to collide with the player
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 direction = Vector3.Normalize (destination - transform.position);
		Debug.Log("direction = " + direction);
		GetComponent<Rigidbody>().AddForce(direction * 10); //adds the speed to the rigidbody of the object in question

		healthText.GetComponent<TextMesh> ().color = Color.white;
		healthText.GetComponent<TextMesh> ().text = "Health: " + playerHealth;
	}

	void OnCollisionEnter(Collision collision) {
		Debug.Log("collision = " + collision.collider);
		if (collision.gameObject.name == "player") { //collision code needed if the enemy touches the player
			playerHealth = playerHealth - 1; //player lose health as enemy touches them
			if (playerHealth == 0) {
				Application.LoadLevel ("gameOver"); //If the health counter reaches zero, the player wil be taken to the game over room.
			}
	}
}
}
