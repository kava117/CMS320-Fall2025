using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField] private SceneLoader sceneLoader;

    // for loading ""static" scenes, the menu/map/etc
    public void ChangeSceneNarration()
    {
        SceneManager.LoadScene("Narration");
    }

    // for loading ""static" scenes, the menu/map/etc
    public void ChangeSceneMap()
    {
        SceneManager.LoadScene("Playing");
    }

    // for loading an event scene
    public void ChangeScenePlaying(string locationName)
    {
        if (locationName == "Florida")
        {
            SceneManager.LoadScene("Playing");
            sceneLoader.LoadScene(locationName);
        }
        else
        {
            sceneLoader.LoadScene(locationName);
        }
    }
}
