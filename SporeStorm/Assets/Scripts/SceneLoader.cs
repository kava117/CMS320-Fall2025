using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    
    public string GetLocation()
    {
        var currentScene = SceneManager.GetActiveScene();
        return currentScene.name; 
    }
}
