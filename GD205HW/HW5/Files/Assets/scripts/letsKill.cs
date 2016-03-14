using UnityEngine;
using System.Collections;

public class letsKill : MonoBehaviour {

    public GameObject victim;
    public GameObject victimClone;
    public GameObject cubeLauncher;
    public Vector3 destination;

	// Use this for initialization
	void Start () {
        destination = victim.transform.position;

    }
	
	// Update is called once per frame
	void Update () {
        //destination = victim1.transform.position;
        Vector3 direction = Vector3.Normalize (destination - transform.position);
        Debug.Log("direction = " + direction);
        GetComponent<Rigidbody>().AddForce(direction * 5);

    }

    void OnCollisionEnter(Collision collision) {
            Debug.Log("collision = " + collision.collider);
            if (collision.gameObject.name == "victim") {
                Destroy(collision.gameObject);
              //collision.gameObject.SetActive(false);

        }
            if (collision.gameObject.name == "victim(Clone)") {
                //Destroy(collision.gameObject);
                collision.gameObject.SetActive(false);
        }
    }
}

//References"
//http://docs.unity3d.com/Manual/Prefabs.html
//http://docs.unity3d.com/Manual/InstantiatingPrefabs.html
//https://unity3d.com/learn/tutorials/modules/beginner/physics/on-collision-enter
//https://unity3d.com/learn/tutorials/modules/beginner/scripting/destroy?playlist=17117
//https://unity3d.com/learn/tutorials/modules/beginner/scripting/activating-gameobjects
//http://docs.unity3d.com/ScriptReference/GameObject.SetActive.html
//https://www.youtube.com/watch?v=4rZAAHevq1s
//http://docs.unity3d.com/ScriptReference/Input.GetMouseButtonDown.html