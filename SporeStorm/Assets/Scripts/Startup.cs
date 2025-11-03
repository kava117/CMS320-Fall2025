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

        // unload startup and load first "gameplay" scene, aka main menu
        await SceneManager.UnloadSceneAsync("Startup");
        await SceneManager.LoadSceneAsync(firstGameplayScene, LoadSceneMode.Additive);
    }
}
