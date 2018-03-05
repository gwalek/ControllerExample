using UnityEngine;

public struct Something
{
    public int value;

    // Struct: 
    // No inheritance, thus no polymorphism
    // Members are Public by Default
    // Is a value, thus cannot be assigned null to a variable of this type
}

public class SomethingElse
{
    public int value;

    // Class: 
    // Supports inheritance, thus supports polymorphism
    // Members are Private by Default
    // Is a reference, thus be assigned null to a variable of this type
}

public class ReferenceValueExamples : MonoBehaviour
{

    Something thing1;
    SomethingElse thing2;
    MonoBehaviour thing3;

    void Start()
    {
        // This works becaue structs variables start with default values
        Debug.Log(" " + thing1.ToString() + " " + thing1.value);

        // this works becuase object references start with null till assigned a reference. 
        if (thing2 == null)
        { }

        // This works because Unity set up operator overloading for us. 
        if (thing3)
        { }

        /*  DOESN'T WORK WITH STRUCTS
        if (thing1 == null) 
        {} 
        */

    }
}