using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawForwardRay : MonoBehaviour {

    Transform trans; 

    // Use this for initialization
	void Start () {
        trans = gameObject.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {

        //Debug.DrawRay(trans.position, trans.forward, Color.yellow);
        Debug.DrawLine(trans.position, (trans.position + (trans.forward * 10f)), Color.yellow, .2f); 
		
	}
}
