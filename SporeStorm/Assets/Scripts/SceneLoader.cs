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
        LoadScene("Florida");
    }

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
        string sceneBackgroundName = locationName + "Background";
        sceneBackground = Resources.Load<Image>($"../Images/Backgrounds/{sceneBackgroundName}");

        DisableMapUI(); // disable the map
        DisableNightUI(); // disable the night
        EnableSceneUI(); // re-enable general ui

        LoadDialogueEvent(locationName); // fetch dialogue and load all dialogue ui
        Debug.Log("scene ladoer: loaded dialogue");




        //backgroundSpriteName = worldstate.GetLocation() + "Background";
        //// find background image
        //backgroundSprite = Resources.Load<Sprite>($"../Images/Backgrounds/{backgroundSpriteName}");
        //// attach
        //Background.sprite = backgroundSprite;
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
        // IMPLEMENT LATER: FETCH MOST RECENT CHANGES/AKA THE STORM's MOVEMENT
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
