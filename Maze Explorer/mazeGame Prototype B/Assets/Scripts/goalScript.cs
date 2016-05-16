using UnityEngine;
using System.Collections;

public class goalScript : MonoBehaviour {

	public GameObject goalArea;


	// Use this for initialization
	void Start () {
	
	}
	
	// 
	void OnCollisionEnter(Collision collision) {
		Debug.Log("collision = " + collision.collider);
		if (collision.gameObject.name == "player") {
			Application.LoadLevel ("winScreen");
	}
}
}