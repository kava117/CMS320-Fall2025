using UnityEngine;
using UnityEngine.UI;

public class MapContinueButton : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private SceneController sceneController;
    [SerializeField] private MapPanelUI mapPanelUI;
    [SerializeField] private Worldstate worldstate;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        button.onClick.AddListener(ChangeLocation);
    }

    private void OnDestroy()
    {
        button.onClick.RemoveListener(ChangeLocation);
    }

    private void ChangeLocation()
    {
        SoundController.Instance.PlayContinueClick();
        Debug.Log("Click sound???");
        string nextLocation = mapPanelUI.GetNextLocation();
        // null guard in case the player hasn't chosen a next location yet
        if (nextLocation == null)
        {
            return;
        }
        else if (nextLocation == worldstate.GetLocation()) 
        {
            return;
        }
        // locks in the user's choice and progresses the game forward
        sceneController.ChangeLocation(nextLocation);
        worldstate.SetLocation(nextLocation);

    }
}
