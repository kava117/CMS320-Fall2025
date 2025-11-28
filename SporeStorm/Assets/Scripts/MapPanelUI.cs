using TMPro;
using UnityEngine;

public class MapPanelUI : MonoBehaviour
{
    [SerializeField] private Worldstate worldstate;

    [SerializeField] private TextMeshProUGUI fuelAmountLeft;
    [SerializeField] private TextMeshProUGUI nextDestination;
    private string nextLocation; // used by mapcontinuebutton to figure out where to go next
    [SerializeField] private MapButtonBehavior[] mapButtons;


    public void LoadMap()
    {
        fuelAmountLeft.text = worldstate.GetFuel() + "";

        // BRIANNE, YOUR STORM CODE GOES HERE
    }

    public void ChangeNextLocation(string locationName)
    {
        // changing ui things
        nextDestination.text = locationName;
        // altering data in worldstate
        nextLocation = locationName;
        ChangeFuelAmount(locationName);

    }

    public void ChangeFuelAmount(string locationname)
    {
        worldstate.ChangeFuel(-5);
        fuelAmountLeft.text = worldstate.GetFuel() + "";
    }

    public string GetNextLocation()
    {
        return nextLocation;
    }
}
