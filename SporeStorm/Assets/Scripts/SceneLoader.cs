using UnityEditor.U2D.Animation;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneLoader : MonoBehaviour
{
    // for fetching game data
    [SerializeField] private Worldstate worldstate;
    [SerializeField] private DialogueManager dialogueManager;
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

    private int sceneLevel = 0;
    private Sprite backgroundSprite;
    private string backgroundSpriteName;


    private void Awake()
    {
        // disables everything from the start for safety
        Debug.Log("disabling everything on awake");
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
        EnableSceneUI(); // re-enable general ui

        LoadDialogueEvent(locationName); // fetch dialogue and load all dialogue ui
        Debug.Log("scene ladoer: loaded dialogue");



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
        // turn off everything else
        DisableSceneUI();
        DisableNightUI();
        // gets the map ui showing
        EnableMapUI(); 
        Debug.Log("loaded map");
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
        LoadNightPanels();
        // turn off everything else first
        DisableSceneUI();
        DisableMapUI();
        // gets night ui showing
        EnableNightUI();
        Debug.Log("loaded night");
    }
    
    private void LoadNightPanels()
    {
        string[] characters = worldstate.GetPeopleInCar();

    }
}
