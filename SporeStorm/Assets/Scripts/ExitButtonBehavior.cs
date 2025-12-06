using UnityEngine;
using UnityEngine.UI;

public class ExitButtonBehavior : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private SceneController sceneController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        button.onClick.AddListener(ChangeSceneMainMenu);
    }

    private void OnDestroy()
    {
        button.onClick.RemoveListener(ChangeSceneMainMenu);
    }

    private void ChangeSceneMainMenu()
    {
        SoundController.Instance.PlayClick();
        sceneController.ChangeSceneMainMenu();
    }
}
