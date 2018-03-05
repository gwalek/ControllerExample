using UnityEngine;
using UnityEngine.SceneManagement;

public class Door_LoadScene : MonoBehaviour
{
    public string nextScene; 

    public void LoadScene()
    {
        SceneManager.LoadScene(nextScene);
    }
    // API Reference: 
    // https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.LoadScene.html
}
