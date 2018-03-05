using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankScript : MonoBehaviour
{
    Transform trans;
    Rigidbody rb;
    public float moveSpeed = 6.0f;
    public float rotateSpeed = 120.0f;
    public bool IsPlayer1 = true;

    bool Forward = false;
    bool Back = false;
    bool TurnCCW = false;
    bool TurnCW = false;
    bool Fire1 = false;
    bool Fire2 = false; 

    // Use this for initialization
    void Start()
    {
        trans = gameObject.GetComponent<Transform>();
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void GetPlayer2Input()
    {
        Forward = Input.GetKey(KeyCode.I);
        Back = Input.GetKey(KeyCode.K);
        TurnCCW = Input.GetKey(KeyCode.J);
        TurnCW = Input.GetKey(KeyCode.L);
        Fire1 = Input.GetKeyDown(KeyCode.U);
        Fire2 = Input.GetKeyDown(KeyCode.O);
    }

    void GetPlayer1Input()
    {
        Forward = Input.GetKey(KeyCode.W);
        Back = Input.GetKey(KeyCode.S);
        TurnCCW = Input.GetKey(KeyCode.A);
        TurnCW = Input.GetKey(KeyCode.D);
        Fire1 = Input.GetKeyDown(KeyCode.Q);
        Fire2 = Input.GetKeyDown(KeyCode.E);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 location = trans.position;

        if (IsPlayer1) { GetPlayer1Input(); }
        else { GetPlayer2Input(); }

        rb.velocity = Vector3.zero;

        if (Forward)
        {
            rb.velocity = trans.forward * moveSpeed;
        }

        if (Back)
        {
            rb.velocity = -1 * trans.forward * moveSpeed;
        }

        if (TurnCW)
        {
            trans.Rotate(0, rotateSpeed * Time.deltaTime, 0);
        }

        if (TurnCCW)
        {
            trans.Rotate(0, -1 * rotateSpeed * Time.deltaTime, 0);
        }

        if (Fire1)
        {

        }

        if (Fire2)
        {

        }

    }
}