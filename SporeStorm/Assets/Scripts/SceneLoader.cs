using UnityEditor.U2D.Animation;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneLoader : MonoBehaviour
{
    [SerializeField] private DialogueController dialogueController;
    [SerializeField] private NPC temporary;
    private int sceneLevel = 0;
    [SerializeField] private Image backgroundCanvas;
    private Sprite backgroundSprite;
    private string backgroundSpriteName;


    private void Awake()
    {
        //AssignBackground("Missouri");

        LoadDialogueEvent("Jane");
    }

    public void LoadDialogueEvent(string locationName)
    {
        dialogueController.StartDialogue(temporary);
    }

    public void AssignBackground(string locationName)
    {
        backgroundSpriteName = locationName + "Background";
        // find background image
        backgroundSprite = Resources.Load<Sprite>($"../Images/Backgrounds/{backgroundSpriteName}");
        // attach
        backgroundCanvas.sprite = backgroundSprite;
    }

    public string GetLocation()
    {
        var currentScene = SceneManager.GetActiveScene();
        return currentScene.name;
    }
}
