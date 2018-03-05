using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayListExample : MonoBehaviour {

    public int[] IntArray;
    public GameObject[] GameObjectArray;
    public List<GameObject> GameObjectList;

    int GameObjectArrayIndex = 0; 

    // Use this for initialization
    void Start () {
        ShowLengths();
        ShowNameAtFirstElement(); 
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShowNameAtElement(); 
        }
    }

    void ShowLengths()
    {
        Debug.Log("IntArray : " + IntArray.Length);
        Debug.Log("GameObjectArray : " + GameObjectArray.Length);
        Debug.Log("GameObjectList : " + GameObjectList.Count);
    }

    void ShowNameAtFirstElement()
    {
        Debug.Log("First in GameObjectArray : " + GameObjectArray[0].name);
        Debug.Log("First in GameObjectList : " + GameObjectList[0].name);
    }

    void ShowNameAtElement()
    {
        Debug.Log("#" + GameObjectArrayIndex + " Element in GameObjectArray : " + GameObjectArray[GameObjectArrayIndex].name);

        GameObjectArrayIndex++; 
        if (GameObjectArrayIndex >= GameObjectArray.Length)
        {
            GameObjectArrayIndex = 0; 
        }
    }

}