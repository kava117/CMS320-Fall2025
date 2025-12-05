using System;
using System.Collections;
using System.Collections.Generic;
using Ink.Runtime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialoguePanelUI : MonoBehaviour
{
    [SerializeField] private Worldstate worldstate;

    [Header("Components")]
    [SerializeField] private GameObject contentParent;
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private TextMeshProUGUI dialogueName;
    [SerializeField] private Image dialoguePortrait;
    [SerializeField] private DialogueChoiceButton[] choiceButtons;
    [SerializeField] private GameObject continueIcon;

    [SerializeField] private TextMeshProUGUI gas;
    [SerializeField] private TextMeshProUGUI hours;
    [SerializeField] private TextMeshProUGUI inventory;
    
    private float typingSpeed = 0.04F;
    private Coroutine displayLineCoroutine;
    private bool canContinueToNextLine = false;
    private bool spaceDown = false;
    private int counter = 0;




    //May be temp (audio stuff)
    [SerializeField] private AudioSource typingAudioSource;
    [SerializeField] private AudioClip typingClip;

    [SerializeField] private float typingVolume = 0.5f;
    [SerializeField] private float typingCooldown = 0.02f;

    private float lastTypingTime = 0f;




    private void Awake()
    {
        contentParent.SetActive(false);
        ResetPanel();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && counter >= 5)
        {
            spaceDown = true;
        }
    }

    private void OnEnable()
    {
        GameEventsManager.instance.dialogueEvents.onDialogueStarted += DialogueStarted;
        GameEventsManager.instance.dialogueEvents.onDialogueFinished += DialogueFinished;
        GameEventsManager.instance.dialogueEvents.onDisplayDialogue += DisplayDialogue;
    }
    private void OnDisable()
    {
        GameEventsManager.instance.dialogueEvents.onDialogueStarted -= DialogueStarted;
        GameEventsManager.instance.dialogueEvents.onDialogueFinished -= DialogueFinished;
        GameEventsManager.instance.dialogueEvents.onDisplayDialogue -= DisplayDialogue;
    }

    private void DialogueStarted()
    {
        contentParent.SetActive(true);
    }

    private void DialogueFinished()
    {
        contentParent.SetActive(false);

        // reset panel on dialogue end
        ResetPanel();
    }

    private void DisplayDialogue(string dialogueLine, List<Choice> dialogueChoices)
    {
        // "types" the text onto the screen
        if (displayLineCoroutine != null)
        {
            StopCoroutine(displayLineCoroutine);
        }
        displayLineCoroutine = StartCoroutine(DisplayLine(dialogueLine, dialogueChoices));

        // defensive check, if there are too many choices
        if (dialogueChoices.Count > choiceButtons.Length)
        {
            Debug.LogError("More dialogue choices ("
                + dialogueChoices.Count + ") came through than are supported ("
                + choiceButtons.Length + ").");
        }

        // start w all choice buttons hidden
        HideChoices();
    }

    private IEnumerator DisplayLine(string line, List<Choice> dialogueChoices)
    {
        counter = 0;
        Debug.Log("Decreasing typing speed");
        typingSpeed = 0.04f;


        // empty the dialogue text
        dialogueText.text = "";
        // hide items while text is typing
        continueIcon.SetActive(false);

        canContinueToNextLine = false;

        //AUDIO STUFF -emma
        if (typingAudioSource != null && typingClip != null)
        {
            typingAudioSource.clip = typingClip;
            typingAudioSource.loop = false; 
            typingAudioSource.Play();
        }


        char[] lineInChars = line.ToCharArray();

        for (int i = 0; i < lineInChars.Length; i++)
        {
            counter++;
            dialogueText.text += lineInChars[i];

            if (spaceDown)
            {
                spaceDown = false;
                Debug.Log("Increasing Typing Speed");
                typingSpeed = .000001f;
            }

            yield return new WaitForSeconds(typingSpeed);
        }

        //AUDIO STUFF -emma
        if (typingAudioSource != null)
        {
            typingAudioSource.Stop();
        }


        // show items after typing is done
        continueIcon.SetActive(true);
        DisplayChoices(dialogueChoices);

        canContinueToNextLine = true;
    }

    public bool GetCanContinueToNextLine()
    {
        return canContinueToNextLine;
    }

    public void SetDialogueName(string Name)
    {
        dialogueName.text = Name;
    }

    public void SetDialoguePortrait(string Name)
    {
        string portraitPath = $"Images/Sprites/NPCs/{Name}PortraitDefault";
        Sprite loadedPortrait = Resources.Load<Sprite>(portraitPath);
        dialoguePortrait.sprite = loadedPortrait;
    }

    private void ResetPanel()
    {
        dialogueText.text = "";
    }

    private void DisplayChoices(List<Choice> dialogueChoices)
    {
        // enable and set info for buttons depending on ink choice info
        int choiceButtonIndex = dialogueChoices.Count - 1;
        for (int inkChoiceIndex = 0; inkChoiceIndex < dialogueChoices.Count; inkChoiceIndex++)
        {
            Choice dialogueChoice = dialogueChoices[inkChoiceIndex];
            DialogueChoiceButton choiceButton = choiceButtons[choiceButtonIndex];

            choiceButton.gameObject.SetActive(true);
            choiceButton.SetChoiceText(dialogueChoice.text);
            choiceButton.SetChoiceIndex(inkChoiceIndex);

            if (inkChoiceIndex == 0)
            {
                choiceButton.SelectButton();
                GameEventsManager.instance.dialogueEvents.UpdateChoiceIndex(0);
            }

            choiceButtonIndex--;
        }
    }

    private void HideChoices()
    {
        foreach (DialogueChoiceButton choiceButton in choiceButtons)
        {
            choiceButton.gameObject.SetActive(false);
        }
    }

    private void HaltCoroutine(List<Choice> dialogueChoices)
    {


        //AUDIO STUFF -emma
        if (typingAudioSource != null)
        {
            typingAudioSource.Stop();
        }


        // show items after typing is done
        continueIcon.SetActive(true);
        DisplayChoices(dialogueChoices);

        canContinueToNextLine = true;
    }
}
