using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalNetScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        
        if (other.tag == "Ball")
        {
            Debug.Log("GOOOOOAAAAAL!");

            Rigidbody other_RB = other.gameObject.GetComponent<Rigidbody>();
            other_RB.velocity = Vector3.zero;
            other_RB.rotation = Quaternion.Euler(Vector3.zero); 

            other.gameObject.transform.position = Vector3.zero;
            other.gameObject.transform.position = new Vector3(0, 3, 0);


        }
    }

}
