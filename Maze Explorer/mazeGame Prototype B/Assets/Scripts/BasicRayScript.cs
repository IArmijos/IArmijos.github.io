//This code will be used so that when the character points at something in the screen, they will shoot an object to defeat an enemy.
using UnityEngine;
using System.Collections;

public class BasicRayScript : MonoBehaviour {

	public Transform obj;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		//Determines the character's line of sight where he can shoot projectives (the "obj")
		Ray myRay = Camera.main.ScreenPointToRay (Input.mousePosition);
		//Camera.main.transform.LookAt (myRay.direction); //This code is disabled since it interferes with the camera function of the main game.
		Debug.DrawRay (myRay.origin, myRay.direction * 1000, Color.red);

		RaycastHit rayhit = new RaycastHit ();

		//Pressing the mouse button will cause an object to appear...
		if (Physics.Raycast (myRay, out rayhit, 1000f) && Input.GetMouseButtonDown(0)){
			Debug.Log("You hit " + rayhit.transform);
			Instantiate(obj, rayhit.point, Random.rotation);
		}
	}
}