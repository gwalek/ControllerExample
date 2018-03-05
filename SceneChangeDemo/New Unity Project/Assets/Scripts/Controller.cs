using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour {

    public GameObject parent;
    public bool doItRight = true; 
    Door_LoadScene DLS = null;  

    // Awake is a timing function that takes place before Start
    void Awake()
    {
        DontDestroyOnLoad(parent);
        // when we call this, we're setting up objects that are persistant from scene to scene. 
    }
    // API Reference: 
    // https://docs.unity3d.com/ScriptReference/Object.DontDestroyOnLoad.html

    public void BeginGame()
    {
        SceneManager.LoadScene("Room_Red");
    }

    void Update()
    {
        if (doItRight)  { DoneRight(); }
        else            { DoneWrong(); }

    }

    void DoneRight()
    { 
        DLS = null;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 500, Color.red);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            DLS = hit.transform.gameObject.GetComponent<Door_LoadScene>();
        }

        if (DLS)
        {
            if (Input.GetMouseButtonDown(0))
            {
                DLS.LoadScene();
            }
        }
    }

    // Okay, You're likely going to write your code this way first. 
    // Here's what happens if you do this way. LOL
    void DoneWrong()
    {
        DLS = null;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 500, Color.red);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            DLS = hit.transform.gameObject.GetComponent<Door_LoadScene>();
            if (DLS)
            {
                DLS.LoadScene();
                
            }
        }
        
    }

}


