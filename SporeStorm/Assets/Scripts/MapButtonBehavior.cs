using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MapButtonBehavior : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private Worldstate worldstate;
    [SerializeField] private MapPanelUI mapPanelUI;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        button.onClick.AddListener(ChangeNextLocation);
    }

    private void OnDestroy()
    {
        button.onClick.RemoveListener(ChangeNextLocation);
    }

    private void ChangeNextLocation()
    {
        // calls function from map panel ui and worldstate to alter the next
        // location depending on where the user presses
        mapPanelUI.ChangeNextLocation(button.name);
    }
}
