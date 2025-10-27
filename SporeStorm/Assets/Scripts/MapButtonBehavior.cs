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
        button.onClick.AddListener(ChangeSceneEvent);
    }

    private void OnDestroy()
    {
        button.onClick.RemoveListener(ChangeSceneEvent);
    }

    private void ChangeSceneEvent()
    {
        sceneController.ChangeScene("Event", button.name);
    }
}
