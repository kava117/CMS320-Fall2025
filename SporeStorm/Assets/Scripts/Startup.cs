using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startup : MonoBehaviour
{
    private string persistentSceneName = "Manager";
    private string firstGameplayScene = "MainMenu";

    private async void Awake()
    {
        // load persistent systems if not already loaded
        if (!SceneManager.GetSceneByName(persistentSceneName).isLoaded)
        {
            await SceneManager.LoadSceneAsync(persistentSceneName, LoadSceneMode.Additive);
            Debug.Log("Loaded persistent systems.");
        }

        await Task.Yield(); // lets one frame pass to make sure everything is set up good

        // load mainmenu and wait for it to finish
        AsyncOperation menuLoad = SceneManager.LoadSceneAsync(firstGameplayScene, LoadSceneMode.Additive);
        while (!menuLoad.isDone)
            await Task.Yield();
        Debug.Log("menu loaded");

        // set main menu as active
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(firstGameplayScene));
        Debug.Log("main menu set as active");

        await Task.Yield(); // waits another frame

        // unload startup 
        var unload = SceneManager.UnloadSceneAsync("Startup");
        await unload;
        Debug.Log("Startup scene unloaded");
    }
}
