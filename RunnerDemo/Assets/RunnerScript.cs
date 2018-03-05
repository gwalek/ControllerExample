using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerScript : MonoBehaviour {
  
    public GameObject targetA;
    public GameObject targetB;
    public float movementSpeed = 4.0f;
    public bool HasDynamicDirection = false;
    public bool HasFacingUpdate = true;


    Transform trans;
    GameObject targetCurrent;
    bool IsMovingToA = false;
    Vector3 MovementDirection = Vector3.zero; 
    
    // Use this for initialization
    void Start () {
        trans = gameObject.transform;

        NextTarget();
        UpdateMoveDirection(); 
        
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 Location = trans.position; 

        if (HasDynamicDirection)
        {
            UpdateMoveDirection(); 
        }

        Location += (MovementDirection * movementSpeed * Time.deltaTime);

        trans.position = Location; 

        if (IsClosetoTarget())
        {
            NextTarget();
            UpdateMoveDirection();
        }
		
	}

    public float GetDistanceTo(GameObject Other)
    {
        return (trans.position - Other.transform.position).magnitude; 
    }

    public bool IsClosetoTarget()
    {
        bool result = false;

        if (GetDistanceTo(targetCurrent) < (movementSpeed* Time.deltaTime))
        {
            result = true; 
        }

        return result;
    }

    public void NextTarget()
    {
        if (IsMovingToA)
        {
            IsMovingToA = false;
            targetCurrent = targetB;
        }
        else
        {
            IsMovingToA = true;
            targetCurrent = targetA;
        }
    }
    
    public void UpdateMoveDirection()
    {
        Vector3 MyPosition = trans.position;
        Vector3 OthersPosition = targetCurrent.transform.position;
        Vector3 DirectionDelta = OthersPosition - MyPosition;
        //Vector3 DirectionDelta = targetCurrent.transform.position - trans.position;
        MovementDirection = DirectionDelta.normalized;

        if (HasFacingUpdate)
        {
            float angle = Vector3.SignedAngle( Vector3.forward, MovementDirection, Vector3.up); 
            trans.rotation = Quaternion.Euler(0, angle, 0);
        }
    }

}
