using UnityEngine;
using Ink.Runtime;
using Unity.VisualScripting;
using UnityEngine.SearchService;
using System.Collections.Generic;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] private SceneLoader sceneLoader;
    [SerializeField] private DialoguePanelUI dialoguePanelUI;
    [SerializeField] private Worldstate worldstate;



    [Header("Ink Story")]
    [SerializeField] private TextAsset inkJson;

    private Story story;
    private string currentCharacter;

    private int currentChoiceIndex = -1;
  //  private int index = 0;

    private bool dialoguePlaying = false;

    // TAGS
    // ui tags
    private const string SPEAKER_TAG = "speaker";
    // game logic tags
    private const string GAMEOVER_TAG = "gameover";
    private const string GAMEWIN_TAG = "gamewin";
    private const string JOIN_TAG = "joining"; // only this and the ones above matters for playtest

    private const string HOURS_TAG = "hours";
    private const string FOOD_TAG = "food";
    private const string WATER_TAG = "water";
    private const string GAS_TAG = "gas";



    private void Awake()
    {
        story = new Story(inkJson.text);
    }



    private void OnEnable()
    {
        GameEventsManager.instance.dialogueEvents.onEnterDialogue += EnterDialogue;
        GameEventsManager.instance.dialogueEvents.onUpdateChoiceIndex += UpdateChoiceIndex;
    }

    private void OnDisable()
    {
        GameEventsManager.instance.dialogueEvents.onEnterDialogue -= EnterDialogue;
        GameEventsManager.instance.dialogueEvents.onUpdateChoiceIndex -= UpdateChoiceIndex;
    }

    private void UpdateChoiceIndex(int choiceIndex)
    {
        this.currentChoiceIndex = choiceIndex;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // if dialogue not playing, you cant let the user skip dialogue
            if (!dialoguePlaying)
            {
                return;
            }
            else if (dialoguePanelUI.GetCanContinueToNextLine())
            {
                ContinueOrExitStory();
            }
        }
    }


    private void EnterDialogue(string knotName)
    {
        // inform other parts of the system dialogue is starting
        GameEventsManager.instance.dialogueEvents.DialogueStarted();


        // only enter dialogue once
        if (dialoguePlaying)
        {
            Debug.Log("stop clicking");
            return;
        }
        dialoguePlaying = true;

        // jump to the knot
        if (!knotName.Equals(""))
        {
            story.ChoosePathString(knotName);
        }
        else
        {
            Debug.LogWarning("DialogueManager: knot name is empty string when entering dialogue");
        }

        // kick off the story
        ContinueOrExitStory();
    }

    private void ContinueOrExitStory()
    {
        // make a choice, if applicable
        if (story.currentChoices.Count > 0 && currentChoiceIndex != -1)
        {
            story.ChooseChoiceIndex(currentChoiceIndex);
            // reset choice index for next time
            currentChoiceIndex = -1;
        }

        if (story.canContinue)
        {
            string dialogueLine = story.Continue();
            GameEventsManager.instance.dialogueEvents.DisplayDialogue(dialogueLine, story.currentChoices);
            // parse and handle tags
            HandleTags(story.currentTags);
        }
        else if (story.currentChoices.Count == 0)
        {
            ExitDialogue();
        }
    }


    private void HandleTags(List<string> currentTags)
    {
        // loop thru each tag and handle accordingly
        foreach (string tag in currentTags)
        {
            // parse
            string[] splitTag = tag.Split(':');
            if (splitTag.Length != 2)
            {
                Debug.LogError("Tag could not be appropriately parsed: " + tag);
            }
            string tagKey = splitTag[0].Trim();
            string tagValue = splitTag[1].Trim();

            // handle the tag
            switch (tagKey)
            {
                case SPEAKER_TAG:
                    Debug.Log("speaker=" + tagValue);
                    dialoguePanelUI.SetDialogueName(tagValue);
                    Debug.Log("trying to set portrait");
                    dialoguePanelUI.SetDialoguePortrait(tagValue);
                    currentCharacter = tagValue;
                    break;
                case HOURS_TAG:
                    Debug.Log("hours=" + tagValue);
                    int numHours = int.Parse(tagValue);
                    bool moreTimeLeft = worldstate.ChangeHoursLeft(-numHours);
                    if (!moreTimeLeft)
                    {
                        // if the player runs out of time during the day
                        ExitDialogue();
                        EnterDialogue("OutOfTime");
                    }
                    break;
                case GAMEOVER_TAG:
                    Debug.Log("gameover=" + tagValue);
                    sceneLoader.LoadGameOver();
                    break;
                case GAMEWIN_TAG:
                    Debug.Log("gamewin=" + tagValue);
                    sceneLoader.LoadGameWin();
                    break;
                case JOIN_TAG:
                    Debug.Log("joining=" + tagValue);
                    worldstate.ChangePeopleInCar(currentCharacter);
                    break;
                case FOOD_TAG:
                    Debug.Log("getting food=" + tagValue);
                    //int numFood = int.Parse(tagValue);
                    //worldstate.ChangeFood(numFood);
                    break;
                case WATER_TAG:
                    Debug.Log("getting water=" + tagValue);
                    //int numWater = int.Parse(tagValue);
                    //worldstate.ChangeWater(numWater);
                    break;
                case GAS_TAG:
                    Debug.Log("getting gas=" + tagValue);
                    //int numGas = int.Parse(tagValue);
                    //worldstate.ChangeFuel(3);
                    break;
                default:
                    Debug.LogWarning("Tag came in but is not currently being handled: " + tag);
                    break;
            }
        }
    }

    private void ExitDialogue()
    {
        Debug.Log("exiting dialogue");

        dialoguePlaying = false;

        // inform other parts of system that dialogue is over
        GameEventsManager.instance.dialogueEvents.DialogueFinished();

        // reset story state
        story.ResetState();

        //// load night scene
        //sceneLoader.LoadNight();

        // for playtest purposes, will go straight to map instead
        sceneLoader.LoadMap();
    }

    
}
