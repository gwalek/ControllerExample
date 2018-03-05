using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMovement : MonoBehaviour
{

    Transform trans;
    public float GridSize = 2.5f;
   
    // Use this for initialization
    void Start()
    {
        trans = gameObject.transform;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 location = trans.position;

        bool keyI = Input.GetKeyDown(KeyCode.I);
        bool keyJ = Input.GetKeyDown(KeyCode.J);
        bool keyK = Input.GetKeyDown(KeyCode.K);
        bool keyL = Input.GetKeyDown(KeyCode.L);

        if (keyI)
        {
            location.z += GridSize;
            trans.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (keyK)
        {
            location.z -= GridSize;
            trans.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (keyJ)
        {
            location.x -= GridSize;
            trans.rotation = Quaternion.Euler(0, 270, 0);
        }
        if (keyL)
        {
            location.x += GridSize;
            trans.rotation = Quaternion.Euler(0, 90, 0);
        }

        trans.position = location;
    }
}
