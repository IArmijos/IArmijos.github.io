using UnityEngine;
using System.Collections;

public class moveMe : MonoBehaviour {
	
	public Vector3 speed = new Vector3 (0f,.0f, 0f);
	public GameObject[] moveablesA;
	public GameObject[] moveablesB;
	public GameObject[] BallA;
	public GameObject[] BallB;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (GetComponent<Transform> ().position);

		//transform.Translate(new Vector3 (Time.deltaTime, 1.5f, .5f));
		//GetComponent<Transform> ().position += speed;
		
		//for (int i = 0; i < 1; i++){
		foreach (GameObject thingToMove in moveablesA) {
			thingToMove.transform.Translate (speed);
			transform.Rotate(new Vector3(3.5f,Time.deltaTime,0f));
		}

		//}
		foreach (GameObject thingToMove in moveablesB) {
			thingToMove.transform.Translate(speed);
			transform.Rotate(new Vector3(0f,Time.deltaTime,-3.5f));
		}

		foreach (GameObject thingToMove in BallA) {
			thingToMove.transform.Translate(speed);
			transform.Rotate(new Vector3(Time.deltaTime,5f,.1f));
			transform.Translate(new Vector3 (1.5f,Time.deltaTime,.5f));
		}
		foreach (GameObject thingToMove in BallB) {
			thingToMove.transform.Translate(speed);
		}			
	}
}

//Credits/Resources and information used
//http://docs.unity3d.com/ScriptReference/Transform.RotateAround.html
//http://docs.unity3d.com/ScriptReference/Transform.Rotate.html
//http://docs.unity3d.com/ScriptReference/Rigidbody.MovePosition.html