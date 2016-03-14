using UnityEngine;
using System.Collections;

public class ballRigidBody : MonoBehaviour {
	public Vector4 movePosition;
	public Rigidbody movingBall;

	// Use this for initialization
	void Start () {
		movingBall = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		movingBall.MovePosition (transform.position + transform.forward * Time.deltaTime);
	}
}
