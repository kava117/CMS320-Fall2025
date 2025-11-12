using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    // for loading ""static" scenes, the menu/map/etc
    public void ChangeScene(string sceneName, string currentSceneName)
    {
        //SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
        //SceneManager.UnloadSceneAsync(currentSceneName);
        SceneManager.LoadScene(sceneName);
    }

    // for loading an event scene
    public void ChangeScene(string sceneName, string currentSceneName, string sceneLocation)
    {
        //SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
        //SceneManager.UnloadSceneAsync(currentSceneName);
        SceneManager.LoadScene(sceneName);
    }
}
