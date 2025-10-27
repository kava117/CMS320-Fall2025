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

    // for loading a "general", static scene (aka: main menu, map, etc.)
    public void ChangeScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    // for loading an event scene
    public void ChangeScene(string name, string sceneEvent)
    {
        SceneManager.LoadScene(name);
        // add sceneloader method here to load the specific event assets
    }
}
