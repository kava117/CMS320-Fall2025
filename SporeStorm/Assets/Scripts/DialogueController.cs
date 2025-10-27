using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.U2D.Animation;
using UnityEngine;

public class DialogueController : MonoBehaviour
{
    private DialogueEvent currentDialogueEvent;
    public static DialogueController Instance;

    private System.Action onDialogueEnd;

    private void Awake()
    {
        Instance = this;
        dialoguePanel.SetActive(false); //making sure everything is hidden at start
    }

    //the dialogueTextUnity is for writing to the text box from UNITY
    //the dialogueText is for writing to the text box from VISUAL STUDIO
    [SerializeField] private TextMeshProUGUI dialogueTextUnity;
    [SerializeField] private JsonReader reader;
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private UnityEngine.UI.Image portraitImage;
    [SerializeField] private GameObject dialoguePanel;

    private DialogueLine[] currentDialogueLines;
    private NPC npcReference;

    private int numSentences;
    private float dialogueSpeed = 0.05f;
    private int index = 0;
    private bool canContinueDialogue = true;
    //private bool moreDialogue = true;
    //private float secondsBetweenSentences = 1.5f;
    private Coroutine writingCoroutine;
    private bool isInDialogue = false;
    public bool IsInDialogue => isInDialogue; //"exposes" the var publicly
    private bool isTyping = false;
    private CharacterData characterData;


    public void StartDialogue(string internalName, string displayName, Sprite portrait = null, NPC npcRef = null)
    {
        if (isInDialogue)
        {
            ContinueDialogue();
            return;
        }

        npcReference = npcRef;
        characterData = NPCManager.Instance.GetCharacterData(internalName);
        currentDialogueEvent = reader.GetDialogueEvent(characterData);

        if (currentDialogueEvent == null || currentDialogueEvent.lines.Length == 0)
        {
            Debug.LogWarning("No dialogue to show.");
            return;
        }

        currentDialogueLines = currentDialogueEvent.lines;
        isInDialogue = true;

        canContinueDialogue = false; // starting to type
        index = 0;
        isTyping = true;

        dialoguePanel.SetActive(true);


        // set npc name and portrait
        nameText.text = displayName;
        portraitImage.sprite = portrait;
        portraitImage.gameObject.SetActive(portrait != null); // hide if none


        NextSentence();
    }

    private void ContinueDialogue()
    {
        // TODO: add implementation for the player to skip/progress dialogue with a button press
        if (!canContinueDialogue)
        {
            // if the player presses "e" early, instantly complete the line
            if (writingCoroutine != null)
            {
                StopCoroutine(writingCoroutine);
                dialogueTextUnity.text = currentDialogueLines[index].text;
                canContinueDialogue = true;
                writingCoroutine = null;
            }

            return; // don't advance until the line is fully shown
        }

        index++; // only move to next line if current is fully shown

        if (index >= currentDialogueLines.Length)
        {
            EndDialogue();
            return;
        }

        canContinueDialogue = false; // starting to type the next line
        NextSentence();
    }

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
        string lineText = currentDialogueLines[index].text;
        string expressionKey = currentDialogueLines[index].expression;

        // show expression sprite
        //if (npcReference != null && !string.IsNullOrEmpty(expressionKey))
        //{
        //    portraitImage.sprite = npcReference.GetExpression(expressionKey);
        //}
        //
        //npcReference?.UpdateExpression(expressionKey);

        isTyping = true;
        dialogueTextUnity.text = "";

        foreach (char c in lineText)
        {
            dialogueTextUnity.text += c;
            yield return new WaitForSeconds(dialogueSpeed);
        }

        canContinueDialogue = true;
        isTyping = false;
        writingCoroutine = null;
    }


    private void EndDialogue()
    {
        if (currentDialogueEvent?.setFlags != null && currentDialogueEvent.setFlags != null)
        {
            foreach (string flag in currentDialogueEvent.setFlags)
            {
                if (flag.StartsWith("npc:"))
                {
                    //Debug.Log($"Setting character flag: {flag}");
                    //characterData.SetFlag(flag, true);

                    var actualFlag = flag.Substring(4);
                    Debug.Log($"Setting character flag: {actualFlag}");
                    characterData.SetFlag(actualFlag, true);
                    Debug.Log($"Check character flag immediately: {characterData.HasFlag(actualFlag)}");
                }
                else
                {
                    Debug.Log($"Setting world flag: {flag}");
                    Worldstate.Instance.SetFlag(flag, true);
                }
            }
        }
        else
        {
            Debug.Log("No flags to set from this dialogue.");
        }

        index = 0;
        dialogueTextUnity.text = "";
        isInDialogue = false;

        dialoguePanel.SetActive(false);

        onDialogueEnd?.Invoke();
        onDialogueEnd = null;
        //return;
    }
}
