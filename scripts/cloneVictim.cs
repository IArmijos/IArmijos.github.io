using UnityEngine;
using System.Collections;

public class cloneVictim : MonoBehaviour
{
    public GameObject victim;
    public Transform cubeLauncher;
    public Vector3 destination;
    public GameObject killer;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(victim, cubeLauncher.position, cubeLauncher.rotation);
            Vector3 direction = Vector3.Normalize(destination - transform.position);
            Debug.Log("direction = " + direction);
            GetComponent<Rigidbody>().AddForce(direction * 5);
            //GameObject victim1Clone = (GameObject)Instantiate(victim1, transform.position, transform.rotation);
        }
      
    }
}