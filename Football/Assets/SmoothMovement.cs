using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothMovement : MonoBehaviour {

    Transform trans; 
    public float moveSpeed = 5.0f;
    public float rotateSpeed = 120.0f; 

	// Use this for initialization
	void Start ()
    {
        trans = gameObject.transform; 
        
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 location = trans.position;

        bool keyW = Input.GetKey(KeyCode.W);
        bool keyS = Input.GetKey(KeyCode.S);
        bool keyA = Input.GetKey(KeyCode.A);
        bool keyD = Input.GetKey(KeyCode.D);

        if (keyW)
        {
            location += trans.forward * moveSpeed * Time.deltaTime;
        }

        if (keyS)
        {
            location -= trans.forward * moveSpeed * Time.deltaTime;
        }

        if (keyD)
        {
            trans.Rotate(0, rotateSpeed * Time.deltaTime, 0);
        }

        if (keyA)
        {
            trans.Rotate(0, -1 * rotateSpeed * Time.deltaTime, 0);
        }

        trans.position = location; 
	}
}
