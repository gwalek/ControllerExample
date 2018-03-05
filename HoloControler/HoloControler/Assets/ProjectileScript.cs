using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour {

    Transform trans; 
    public float MoveSpeed = 100;
    float birthtime = -1;
    public float lifetime = 5; 
    

	// Use this for initialization
	void Start () {
        trans = gameObject.GetComponent<Transform>();
        birthtime = Time.unscaledTime; 
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 Loc = trans.position;
        Loc += MoveSpeed * trans.forward * Time.deltaTime;
        trans.position = Loc; 

        if (Time.unscaledTime > (birthtime + lifetime))
        {
            Destroy(gameObject); 
        }


    }
}
