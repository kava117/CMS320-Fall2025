using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private DialogueController dialogueController;
    [SerializeField] private NPC temporary;


    public void PopulateScene(string locationName)
    {

    }


    public void LoadDialogueEvent()
    {
        dialogueController.StartDialogue(temporary);
    }


    
    public string GetLocation()
    {
        var currentScene = SceneManager.GetActiveScene();
        return currentScene.name; 
    }
}
