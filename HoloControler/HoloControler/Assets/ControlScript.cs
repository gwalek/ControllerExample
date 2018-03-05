using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlScript : MonoBehaviour {

    Transform trans;
    public GameObject projectilePrefab; 
    public float MoveSpeed = 10.0f;
    public float RotateSpeed = 30.0f; 

    // Use this for initialization
    void Start () {
        trans = gameObject.GetComponent<Transform>();
       // projectilePrefab = Instantiate(Resources.Load("Assets/Projectile", typeof(GameObject))) as GameObject;
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 location = trans.position; 
        //Debug.Log("Hello!");

        bool xbox_a = Input.GetButton("Xbox1S_A");
        bool xbox_b = Input.GetButton("Xbox1S_B");
        bool xbox_x = Input.GetButton("Xbox1S_X");
        bool xbox_y = Input.GetButton("Xbox1S_Y");
      
        float dPadV = Input.GetAxis("Xbox1S_dPadV");
        float dPadH = Input.GetAxis("Xbox1S_dPadH");
        float LSV = Input.GetAxis("Xbox1S_LSV");
        float LSH = Input.GetAxis("Xbox1S_LSH");
        float RSV = Input.GetAxis("Xbox1S_RSV");
        float RSH = Input.GetAxis("Xbox1S_RSH");

        bool KB_LSHp = Input.GetButton("KB_LSHp");
        bool KB_LSHm = Input.GetButton("KB_LSHm");

        bool KB_Space = Input.GetButtonDown("KB_Space");
        bool xbox_RB  = Input.GetButtonDown("Xbox1S_RB");
        bool xbox_LB  = Input.GetButtonDown("Xbox1S_LB");

        if (KB_Space|| xbox_RB || xbox_LB)
        {
            Instantiate(projectilePrefab, trans.position + 3 * trans.forward, trans.rotation); 
        }

        if (xbox_a)
        {         
            location += transform.forward * (MoveSpeed * Time.deltaTime); 
        }
        if (xbox_b)
        {
            location -= transform.forward * (MoveSpeed * Time.deltaTime);
        }
        if (xbox_y)
        {
            location += transform.up * (MoveSpeed * Time.deltaTime);
        }
        if (xbox_x)
        {
            location -= transform.up * (MoveSpeed * Time.deltaTime);
        }


        if (KB_LSHp)
        {
            LSH = 1;
        }

        if (KB_LSHm)
        {
            LSH = -1;
        }



        if (LSH != 0)
        {
           trans.Rotate(0, LSH * Time.deltaTime * RotateSpeed, 0);
        }

        if (RSH != 0)
        {
            //trans.Rotate(0, RSH * Time.deltaTime * RotateSpeed, 0);
        }

        if (dPadH != 0)
        {
            //trans.Rotate(0, dPadH * Time.deltaTime * RotateSpeed, 0); 
        }

        trans.position = location;  
    }
}
