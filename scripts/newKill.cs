using UnityEngine;
using System.Collections;

public class newKill : MonoBehaviour {

    public Vector3 destination;
    public GameObject victim;
    public GameObject vicBlueprint;
    public float seekSpeed = 5f;
    Vector3 nearbyPos;

    // Use this for initialization
    /*void Start () {
	
	}*/

    // Update is called once per frame
    void Update() {
        destination = victim.transform.position;
        transform.LookAt(destination);
        if (Vector3.Distance(destination, transform.position) > 6.15f) { //determines the distance the object must reach towards the victim in order to destroy it.
            GetComponent<Rigidbody> ().AddForce(Vector3.Normalize(destination - transform.position) * seekSpeed);
        } else
        {
            Debug.Log("Victim Killed");
            GetComponent<Rigidbody> ().velocity = Vector3.zero;
            GameObject temp = victim;
            MakeVic();
            Destroy(temp);
        }
        if (Input.GetMouseButtonDown(0))
        {
			Debug.Log ("Victim Killed");
			GameObject temp = victim;
			victim.gameObject.SetActive(false);
			Destroy (temp);
			GetComponent<Rigidbody> ().velocity = Vector3.zero;
			MakeVic();

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MakeVic();
        }
    }
		
	void OnCollisionEnter(Collision collision) {
		Debug.Log("collision = " + collision.collider);
		if (collision.gameObject.name == "victim") {
			//Destroy(collision.gameObject);
			collision.gameObject.SetActive(false);
		}

		if (collision.gameObject.name == "victim(Clone)") {
			//Destroy(collision.gameObject);
			collision.gameObject.SetActive(false);
		}

	}
    void MakeVic() {
        Debug.Log("Victim has spawned");
        nearbyPos = destination + Random.insideUnitSphere *  6.5f; 
        GameObject clone = Instantiate(vicBlueprint, nearbyPos, Quaternion.identity) as GameObject;

        victim = clone;
    }

}

//Credits
//Set Active codes: http://docs.unity3d.com/ScriptReference/GameObject.SetActive.html