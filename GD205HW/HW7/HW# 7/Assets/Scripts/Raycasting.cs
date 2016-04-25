using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Raycasting : MonoBehaviour {

    public Transform obj;
	public GameObject scoreText;
	public GameObject timerText;

	float timeLeft = 30.0f;

	int playerScore = 000000;

	// Use this for initialization
	void Start () {
		scoreText.GetComponent<TextMesh> ().color = Color.white;
		scoreText.GetComponent<TextMesh> ().text = "Score Counter " + playerScore;
	
	}

    // Update is called once per frame
	void Update () {

		GetComponent<Rigidbody> ();
		Ray myRay = Camera.main.ScreenPointToRay (Input.mousePosition);
		Camera.main.transform.LookAt (myRay.direction);
		Debug.DrawRay (myRay.origin, myRay.direction * 5000, Color.red);

		RaycastHit rayhit = new RaycastHit ();

		if (Physics.Raycast (myRay, out rayhit, 5000f) && Input.GetMouseButtonDown(0)){
			Debug.Log("You hit " + rayhit.transform);
			Instantiate(obj, rayhit.point, Random.rotation);
			Destroy (rayhit.collider.gameObject);
			scoreText.GetComponent<TextMesh> ().color = Color.white;
			scoreText.GetComponent<TextMesh> ().text = "Score Counter " + playerScore;

			playerScore++;//Adds score for each object destroyed
		}

		timeLeft -= Time.deltaTime;//Timer codes
		timerText.GetComponent<TextMesh> ().text = "Timer:" + Mathf.Round (timeLeft);
		if(timeLeft <0){
			timerText.GetComponent<TextMesh> ().color = Color.white;
			timerText.GetComponent<TextMesh> ().text = "Time's up. Game Over.";
	}
}
}

//references
//http://answers.unity3d.com/questions/333789/raycast-destroys-player.html
//http://answers.unity3d.com/questions/980339/count-down-timer-c-1.html