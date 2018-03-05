using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitApplicationScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Exit Application");
            Application.Quit();
        }

    }
}
