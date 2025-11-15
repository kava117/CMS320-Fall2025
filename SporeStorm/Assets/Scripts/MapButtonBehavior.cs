using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MapButtonBehavior : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private SceneController sceneController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        button.onClick.AddListener(ChangeScenePlaying);
    }

    private void OnDestroy()
    {
        button.onClick.RemoveListener(ChangeScenePlaying);
    }

    private void ChangeScenePlaying()
    {
        //sceneController.ChangeScenePlaying(button.gameObject.name);
        sceneController.ChangeScenePlaying(button.gameObject.name);
    }
}
