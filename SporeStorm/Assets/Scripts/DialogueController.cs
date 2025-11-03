using System.Collections;
using System.ComponentModel;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.U2D.Animation;
using UnityEngine;

public class DialogueController : MonoBehaviour
{
    private DialogueEvent currentDialogueEvent;
    public static DialogueController Instance;
    private DialogueLine[] currentDialogueLines;
    private Coroutine writingCoroutine;
    private System.Action onDialogueEnd;

    // UI things
    [SerializeField] private TextMeshProUGUI dialogueTextUnity;
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private UnityEngine.UI.Image portraitImage;
    [SerializeField] private GameObject dialoguePanel;
    // code things
    [SerializeField] private JsonReader reader;
    private NPC character;
    private float dialogueSpeed = 0.05f;
    private int index = 0;
    // booleans
    private bool canContinueDialogue = true; // is the full text displayed
    private bool isInDialogue = false; // is the player in a dialogue event


    // initializes and makes sure panels and boxes are hidden on start
    private void Awake()
    {
        Instance = this;
        dialoguePanel.SetActive(false);
    }

    public void StartDialogue(NPC npcReference)
    {
        if (isInDialogue)
        {
            ContinueDialogue();
            return;
        }

        character = npcReference;
        currentDialogueEvent = reader.GetDialogueEvent(character.GetCharacterData());

        if (currentDialogueEvent == null || currentDialogueEvent.lines.Length == 0)
        {
            Debug.LogWarning("DialogueController: No dialogue to show");
            return;
        }

        currentDialogueLines = currentDialogueEvent.lines;
        isInDialogue = true;

        canContinueDialogue = false; // text box begins to type
        index = 0;

        dialoguePanel.SetActive(true);

        // set npc name and portrait 
        nameText.text = character.GetNPCName();
        portraitImage.sprite = character.GetDefaultPortrait();
        portraitImage.gameObject.SetActive(character.GetDefaultPortrait() != null); // hides portrait box if none

        NextSentence();
    }

    private void ContinueDialogue()
    {
        if (!canContinueDialogue)
        {
            // if the player presses "e" early, instantly completes current line
            if (writingCoroutine != null)
            {
                StopCoroutine(writingCoroutine);
                dialogueTextUnity.text = currentDialogueLines[index].text;
                canContinueDialogue = true;
                writingCoroutine = null;
            }

            return; // don't advance until line is fully shown
        }

        index++; // only count next line once current is fully shown

        // checking if all lines have been shown
        if (index >= currentDialogueLines.Length)
        {
            EndDialogue();
            return;
        }
        else // continue dialogue
        {
            canContinueDialogue = false; // so player cant skip dialogue before it starts
            NextSentence();
        }
    }

    // makes sure the writing coroutine starts fresh for every line
    private void NextSentence()
    {
        dialogueTextUnity.text = "";

        if (writingCoroutine != null)
        {
            StopCoroutine(writingCoroutine);
        }

        writingCoroutine = StartCoroutine(WriteSentence());
    }

    IEnumerator WriteSentence()
    {
        // getting the text and expression for current line
        string lineText = currentDialogueLines[index].text;
        string expressionkey = currentDialogueLines[index].expression;

        dialogueTextUnity.text = "";

        // iterating over every character and printing one by one
        foreach (char c in lineText)
        {
            dialogueTextUnity.text += c;
            yield return new WaitForSeconds(dialogueSpeed);
        }

        canContinueDialogue = true;
        writingCoroutine = null;
    }

    private void EndDialogue()
    {
        // setting flags and all that jazz
        if (currentDialogueEvent?.setFlags != null && currentDialogueEvent.setFlags != null)
        {
            foreach (string flag in currentDialogueEvent.setFlags)
            {
                if (flag.StartsWith("npc:"))
                {
                    var cleanedFlag = flag.Substring(4);
                    Debug.Log($"DialogueController: Setting character flag: {cleanedFlag}");
                    character.SetFlag(cleanedFlag, true);
                }
                else
                {
                    Debug.Log($"DialogueController: Setting world flag: {flag}");
                    Worldstate.Instance.SetFlag(flag, true);
                }
            }
        }
        else
        {
            Debug.Log("DialogueController: No flags to set from this dialogue");
        }

        // closing up dialogue and resetting counters/bools
        index = 0;
        dialogueTextUnity.text = "";
        isInDialogue = false;

        dialoguePanel.SetActive(false);

        onDialogueEnd?.Invoke();
        onDialogueEnd = null;
    }

}
