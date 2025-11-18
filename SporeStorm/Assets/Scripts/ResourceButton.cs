using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ResourceButton : MonoBehaviour, ISelectHandler
{
    [Header("Components")]
    [SerializeField] private Button button;


    //public void SetChoiceText(string choiceTextString)
    //{
    //    choiceText.text = choiceTextString;
    //}

    //public void SetChoiceIndex(int choiceIndex)
    //{
    //    this.choiceIndex = choiceIndex;
    //}

    //public void SelectButton()
    //{
    //    button.Select();
    //}

    public void OnSelect(BaseEventData eventData)
    {
        //GameEventsManager.instance.dialogueEvents.UpdateChoiceIndex(choiceIndex);
    }
}
