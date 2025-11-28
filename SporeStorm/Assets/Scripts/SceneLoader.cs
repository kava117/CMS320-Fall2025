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
    [SerializeField] private GameOverUI gameOverUI;
    // SCENE ui things
    [SerializeField] private Canvas sceneUI;
    [SerializeField] private Image sceneBackground;
    [SerializeField] private Image portraitPanel;
    [SerializeField] private Image sun;
    [SerializeField] private Image gas;
    [SerializeField] private Image inventory;
    // MAP ui things
    [SerializeField] private Canvas mapUI;
    [SerializeField] private Image mapBackground;
    [SerializeField] private Image storm;
    [SerializeField] private Sprite FloridaButton;
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
        DisableMapUI(); // disable the map
        DisableNightUI(); // disable the night
        /*
         * BRIANNE AND EMMA, YOUR GUYS' CODE WILL GO HERE.
         * 
         * Brianne; you need to load in specific art assets that match a certain scene
         * so if i pass in the locationName "Missouri", it will load the background
         * and character portrait for the missouri person
         * 
         * Emma; you will write your code in the music/sfx manager you make, but you
         * should call it right here so it loads on start
         * (UNLESS you have a different solution, then go ahead and do whatever you
         * are thinking and if you are not sure just text me)
         */
        //// BRIANNE'S ART LOADING IMPLEMENTATION
        LoadSceneAssets(locationName);
        EnableSceneUI(); // re-enable general ui

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
        
        /** Load portrait for this location
        string portraitPath = $"Images/Backgrounds/{locationName}Portrait";
        Sprite loadedPortrait = Resources.Load<Sprite>(portraitPath);
        
        if (loadedPortrait != null)
        {
            portraitPanel.sprite = loadedPortrait;
            Debug.Log($"Successfully loaded portrait: {portraitPath}");
        }
        else
        {
            Debug.LogError($"Failed to load portrait at path: {portraitPath}");
        }
        
        // Sun, gas, and inventory images stay the same across all scenes
        // (They should be assigned in the Inspector as they don't change)
        */
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
        /*
         * Brianne, you will implement the stuff to "update" the map and get the correct
         * version of it + the storm depending on the day it is (which can be found in
         * the worldstate class)
         */
        Debug.Log("trying ot load map");

        // BRIANNE'S MAP LOADING IMPLEMENTATION
        LoadMapAssets();
        mapPanelUI.LoadMap();
        // turn off everything else
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
        int currentDay = worldstate.GetDayNumber();
        // Clamp the day between 0 and 9 to be safe
        currentDay = Mathf.Clamp(currentDay, 0, 9);
        
        string stormPath = $"Images/Map/Storm({currentDay})";
        Sprite loadedStorm = Resources.Load<Sprite>(stormPath);
        
        if (loadedStorm != null)
        {
            storm.sprite = loadedStorm;
            Debug.Log($"Successfully loaded storm for day {currentDay}: {stormPath}");
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
        DisableMapUI();
        DisableNightUI();
        DisableSceneUI();

        EnableGameOverUI();
    }
}
