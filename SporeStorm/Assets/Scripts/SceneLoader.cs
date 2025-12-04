using UnityEditor.U2D.Animation;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneLoader : MonoBehaviour
{
    // for fetching game data
    [SerializeField] private Worldstate worldstate;
    [SerializeField] private DialogueManager dialogueManager;
    [SerializeField] private NightPanelUI nightPanelUI;
    [SerializeField] private MapPanelUI mapPanelUI;
    [SerializeField] private GameOverUI gameOverPanelUI;
    // GAMEOVER ui things
    [SerializeField] private Canvas gameOverUI;
    // GAMEWIN ui things
    [SerializeField] private Canvas gameWinUI;
    // SCENE ui things
    [SerializeField] private Canvas sceneUI;
    [SerializeField] private Image sceneBackground;
    [SerializeField] private Image portraitPanel;
    // MAP ui things
    [SerializeField] private Canvas mapUI;
    [SerializeField] private Image mapBackground;
    [SerializeField] private Image storm;
    // NIGHT ui things
    [SerializeField] private Canvas nightUI;

   // private int sceneLevel = 0;
    private Sprite backgroundSprite;
    private string backgroundSpriteName;


    private void Awake()
    {
        // disables everything from the start for safety
        Debug.Log("disabling everything on awake");
        DisableGameOverUI();
        DisableMapUI();
        DisableNightUI();
    }

    private void Start()
    {
        // boots up the florida scene, includes images, dialogue, and sound
        LoadScene("Florida");
    }

    // fetches dialogue stuff from the ink manager classes,
    // also handles booting up the dialogue ui
    public void LoadDialogueEvent(string locationName)
    {
        GameEventsManager.instance.dialogueEvents.EnterDialogue(locationName);
    }


    /**
     * SCENE STUFF
     */
    public void EnableSceneUI()
    {
        sceneUI.gameObject.SetActive(true);
    }

    public void DisableSceneUI()
    {
        sceneUI.gameObject.SetActive(false);
    }

    public void LoadScene(string locationName)
    {
        DisableGameOverUI();
        DisableGameWinUI();
        DisableMapUI(); // disable the map
        DisableNightUI(); // disable the night
        //// BRIANNE'S ART LOADING IMPLEMENTATION
        LoadSceneAssets(locationName);
        EnableSceneUI(); // re-enable general ui

        //SoundController.Instance.PlayBackgroundMusic(); // play background music when playing scene loads


        LoadDialogueEvent(locationName); // fetch dialogue and load all dialogue ui
        Debug.Log("scene loader: loaded dialogue");
    }

    // Loads all visual assets for a specific location scene
    private void LoadSceneAssets(string locationName)
    {
        Debug.Log($"Loading assets for {locationName}");
        
        // Load background sprite
        string backgroundPath = $"Images/Backgrounds/{locationName}Background";
        Sprite loadedBackground = Resources.Load<Sprite>(backgroundPath);
        
        if (loadedBackground != null)
        {
            sceneBackground.sprite = loadedBackground;
            backgroundSprite = loadedBackground;
            backgroundSpriteName = locationName;
            Debug.Log($"Successfully loaded background: {backgroundPath}");
        }
        else
        {
            Debug.LogError($"Failed to load background at path: {backgroundPath}");
        }
    }


    /**
     * MAP STUFF
     */
    public void EnableMapUI()
    {
        mapUI.gameObject.SetActive(true);
    }

    public void DisableMapUI()
    {
        mapUI.gameObject.SetActive(false);
    }

    public void LoadMap()
    {
        Debug.Log("trying ot load map");

        // BRIANNE'S MAP LOADING IMPLEMENTATION
        LoadMapAssets();
        mapPanelUI.LoadMap();
        // turn off everything else
        DisableGameWinUI();
        DisableGameOverUI();
        DisableSceneUI();
        DisableNightUI();
        // gets the map ui showing
        EnableMapUI(); 
        Debug.Log("loaded map");
    }

    // Loads map background and updates storm position based on current day
    private void LoadMapAssets()
    {
        // Load the map background (stays the same)
        string mapPath = "Images/Map/MapF";
        Sprite loadedMap = Resources.Load<Sprite>(mapPath);
        
        if (loadedMap != null)
        {
            mapBackground.sprite = loadedMap;
            Debug.Log($"Successfully loaded map: {mapPath}");
        }
        else
        {
            Debug.LogError($"Failed to load map at path: {mapPath}");
        }
        
        // Load the storm sprite based on current day (0-9)
        //int locationsVisited = worldstate.GetLocationHistory().Length;
        // Clamp the day between 0 and 9 to be safe
        //int dayCurrent = Mathf.Clamp(locationsVisited, 0, 9) + 1;
        int locationsVisited = worldstate.GetLocationsVisited() * 2;


        string stormPath = $"Images/Map/Storm({locationsVisited})";
        Sprite loadedStorm = Resources.Load<Sprite>(stormPath);
        
        if (loadedStorm != null)
        {
            storm.sprite = loadedStorm;
            Debug.Log($"Successfully loaded storm for day {locationsVisited}: {stormPath}");
        }
        else
        {
            Debug.LogError($"Failed to load storm at path: {stormPath}");
        }
    }

    /**
     * NIGHT STUFF
     */
    public void EnableNightUI()
    {
        nightUI.gameObject.SetActive(true);
    }

    public void DisableNightUI()
    {
        nightUI.gameObject.SetActive(false);
    }

    public void LoadNight()
    {
        // IMPLEMENT LATER: FETCH MOST RECENT CHANGES
        Debug.Log("trying to load night");
        nightPanelUI.LoadNight();
        // turn off everything else first
        DisableGameWinUI();
        DisableSceneUI();
        DisableMapUI();
        DisableGameOverUI();
        // gets night ui showing
        EnableNightUI();
        Debug.Log("loaded night");
    }

    /**
     * GAME OVER
     */
    public void EnableGameOverUI()
    {
        gameOverUI.gameObject.SetActive(true);
    }

    public void DisableGameOverUI()
    {
        gameOverUI.gameObject.SetActive(false);
    }



    public void LoadGameOver()
    {
        //audio stuff -emma
        SoundController.Instance.PlayBadEndingSong();


        DisableMapUI();
        DisableNightUI();
        DisableSceneUI();
        DisableGameWinUI();

        EnableGameOverUI();
    }


    /**
     * GAME WIN
     */
    public void EnableGameWinUI()
    {
        gameWinUI.gameObject.SetActive(true);
    }

    public void DisableGameWinUI()
    {
        gameWinUI.gameObject.SetActive(false);
    }

    public void LoadGameWin()
    {

        SoundController.Instance.PlayGoodEndingSong();

        DisableMapUI();
        DisableNightUI();
        DisableSceneUI();
        DisableGameOverUI();

        EnableGameWinUI();
    }
}
