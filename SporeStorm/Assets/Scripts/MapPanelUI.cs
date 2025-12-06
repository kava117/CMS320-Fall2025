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
        LoadMapButtons(worldstate.GetLocation());

        fuelAmountLeft.text = worldstate.GetFuel() + "";

        // BRIANNE, YOUR STORM CODE GOES HERE
    }

    private void LoadMapButtons(string currentLocation)
    {
        // turn off all of them to start
        foreach (MapButtonBehavior mapButton in mapButtons)
        {
            mapButton.gameObject.SetActive(false);
        }

        if (currentLocation == "Florida")
        {
            //mississippi missouri
            mapButtons[0].gameObject.SetActive(true); // missouri
            mapButtons[1].gameObject.SetActive(true); // mississippi
        }
        else if (currentLocation == "Mississippi")
        {
            //nebraska
            mapButtons[3].gameObject.SetActive(true); // nebraska
        }
        else if (currentLocation == "Missouri")
        {
            //nebraska illinois
            mapButtons[2].gameObject.SetActive(true); // illinois
            mapButtons[3].gameObject.SetActive(true); //nebraska
        }
        else if (currentLocation == "Nebraska")
        {
            //south dakota north dakota
            mapButtons[4].gameObject.SetActive(true); // north dakota
            mapButtons[5].gameObject.SetActive(true); // south dakota
        }
        else if (currentLocation == "Illinois")
        {
            //north dakota
            mapButtons[4].gameObject.SetActive(true); // north dakota
        }
        else if (currentLocation == "SouthDakota")
        {
            //Wyoming
            mapButtons[6].gameObject.SetActive(true); // wyoming
        }
        else if (currentLocation == "NorthDakota")
        {
            //wyoming
            mapButtons[6].gameObject.SetActive(true); // wyoming
        }
        else if (currentLocation == "Wyoming")
        {
            //Idaho washington
            mapButtons[7].gameObject.SetActive(true); // idaho
            mapButtons[10].gameObject.SetActive(true); // washington
        }
        else if (currentLocation == "Idaho")
        {
            //Washington utah arizona
            mapButtons[10].gameObject.SetActive(true); // washington
            mapButtons[8].gameObject.SetActive(true); // utah
            mapButtons[9].gameObject.SetActive(true); // arizona
        }
        else if (currentLocation == "Utah")
        {
            //arizona washingotn
            mapButtons[10].gameObject.SetActive(true); // washington
            mapButtons[9].gameObject.SetActive(true); // arizona
        }
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
