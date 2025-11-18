using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

/*
 * this class is STRICTLY for changing scenes as in the actual unity object scenes, not
 * for loading/changing assets. that stuff goes in SceneLoader
 */
public class SceneController : MonoBehaviour
{
    [SerializeField] private SceneLoader sceneLoader;

    // for loading ""static" scenes, the menu/map/etc
    public void ChangeSceneNarration()
    {
        SceneManager.LoadScene("Narration");
    }

    // for loading an event scene
    public void ChangeScenePlaying()
    {
        SceneManager.LoadScene("Playing");
    }

    public void ChangeLocation(string locationName)
    {
        sceneLoader.LoadScene(locationName);
    }
}
