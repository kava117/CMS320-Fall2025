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

    [SerializeField] private TextMeshProUGUI gas;
    [SerializeField] private TextMeshProUGUI hours;
    [SerializeField] private TextMeshProUGUI inventory;
    //private float dialogueSpeed = 8F;

    private void Awake()
    {
        contentParent.SetActive(false);
        ResetPanel();
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
        UpdateIcons();
    }

    private void DialogueFinished()
    {
        contentParent.SetActive(false);

        // reset panel on dialogue end
        ResetPanel();
    }

    private void DisplayDialogue(string dialogueLine, List<Choice> dialogueChoices)
    {
        dialogueText.text = dialogueLine;
        //WriteSentence(dialogueLine, dialogueChoices);

        // defensive check, if there are too many choices
        if (dialogueChoices.Count > choiceButtons.Length)
        {
            Debug.LogError("More dialogue choices ("
                + dialogueChoices.Count + ") came through than are supported ("
                + choiceButtons.Length + ").");
        }

        // start w all choice buttons hidden
        foreach (DialogueChoiceButton choiceButton in choiceButtons)
        {
            choiceButton.gameObject.SetActive(false);
        }

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

    public void SetDialogueName(string Name)
    {
        dialogueName.text = Name;
    }

    //private void SetDialoguePortrait(string Name)
    //{
    //    dialoguePortrait.sprite = Name;
    //}

    private void ResetPanel()
    {
        dialogueText.text = "";
    }

    public void UpdateIcons()
    {
        gas.text = worldstate.GetFuel() + "";
        inventory.text = worldstate.GetWater() + "";
        hours.text = worldstate.GetHoursLeft() + "";
    }






    ///*
    // * this is what gives the "typing" effect
    // */
    //IEnumerator WriteSentence(string lineText, List<Choice> dialogueChoices)
    //{
    //    dialogueText.text = "";

    //    foreach (char c in lineText)
    //    {
    //        dialogueText.text += c;
    //        yield return new WaitForSeconds(dialogueSpeed);
    //    }

    //    DisplayChoices(dialogueChoices);
    //}

    //private void DisplayChoices(List<Choice> dialogueChoices)
    //{
    //    // enable and set info for buttons depending on ink choice info
    //    int choiceButtonIndex = dialogueChoices.Count - 1;
    //    for (int inkChoiceIndex = 0; inkChoiceIndex < dialogueChoices.Count; inkChoiceIndex++)
    //    {
    //        Choice dialogueChoice = dialogueChoices[inkChoiceIndex];
    //        DialogueChoiceButton choiceButton = choiceButtons[choiceButtonIndex];

    //        choiceButton.gameObject.SetActive(true);
    //        choiceButton.SetChoiceText(dialogueChoice.text);
    //        choiceButton.SetChoiceIndex(inkChoiceIndex);

    //        if (inkChoiceIndex == 0)
    //        {
    //            choiceButton.SelectButton();
    //            GameEventsManager.instance.dialogueEvents.UpdateChoiceIndex(0);
    //        }

    //        choiceButtonIndex--;
    //    }
    //}
}
