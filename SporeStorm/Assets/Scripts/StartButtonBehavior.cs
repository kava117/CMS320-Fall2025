using UnityEngine;
using UnityEngine.UI;

public class StartButtonBehavior : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private SceneController sceneController;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        button.onClick.AddListener(ChangeSceneNarration);
    }

    private void OnDestroy()
    {
        button.onClick.RemoveListener(ChangeSceneNarration);
    }

    private void ChangeSceneNarration()
    {
        sceneController.ChangeScene("Narration", "Menu");
    }
}
