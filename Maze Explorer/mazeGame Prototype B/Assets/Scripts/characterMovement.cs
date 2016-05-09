//This code is strictly made to be able to move the player character in my game. Please note that the primitive shapes used in this prototype is only
//a placeholder until the actual graphics are made..
using UnityEngine;
using System.Collections;

public class characterMovement : MonoBehaviour {

	public float playerSpeed = 25f;
	public float rotateSpeed = 200f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//This code is used to rotate the object clockwise. This code is accompanied with the rotateSpeed in order to make
		//the object rotation possible. The Time.deltaTime is used to add to the rotation speed of the file...
		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate (Vector3.up, rotateSpeed * Time.deltaTime); 
		}

		//This code is used to rotate the object counter-clockwisee. The rotateSpeed code found here now has a minus sign so
		//that when the action is performed, the character object will turn to the left side.
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate (Vector3.up, -rotateSpeed * Time.deltaTime);
		}

		//This code is added to let the character move forward. The Vector3.forward is used to guide the player forward while the
		//playerSpeed determines how fast the player will move forward.
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (Vector3.forward * playerSpeed * Time.deltaTime); //By
		}

		//This code is added to let the character move back. The Vector3.Forward code now has a minus sign. This is because Vector3.backward
		//doesn't exist.
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (-Vector3.forward * playerSpeed * Time.deltaTime); //By
		}
	}
}

//references
//https://unity3d.com/learn/tutorials/modules/beginner/scripting/translate-and-rotate
//http://docs.unity3d.com/ScriptReference/Transform-forward.html