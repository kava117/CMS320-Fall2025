using UnityEngine;
using Ink.Runtime;
using Unity.VisualScripting;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] private SceneController sceneController;
    [SerializeField] private GameObject Portrait;


    [Header("Ink Story")]
    [SerializeField] private TextAsset inkJson;

    private Story story;

    private int currentChoiceIndex = -1;
    private int index = 0;

    private bool dialoguePlaying = false;

    private void Awake()
    {
        Portrait.SetActive(false);
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
            
            ContinueOrExitStory();
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


            // for now, just print to console
            Debug.Log(dialogueLine);
        }
        else if (story.currentChoices.Count == 0)
        {
            ExitDialogue();
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
    }
}
