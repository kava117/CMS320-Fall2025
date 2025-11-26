using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NightPanelUI : MonoBehaviour
{
    [SerializeField] private Worldstate worldstate;

    [SerializeField] private CharacterPanel[] characterPanels;

    [SerializeField] private GameObject contentParent;
    [SerializeField] private TextMeshProUGUI dayComplete;
    [SerializeField] private TextMeshProUGUI recapText;

    [SerializeField] private TextMeshProUGUI foodAmount;
    [SerializeField] private TextMeshProUGUI waterAmount;

    
    void Awake()
    {
        // start w all choice buttons hidden
        foreach (CharacterPanel characterPanel in characterPanels)
        {
            characterPanel.gameObject.SetActive(false);
        }
    }

    public void LoadNight()
    {
        // put the amt of food and water up on the screen
        foodAmount.text = worldstate.GetFood() + "";
        waterAmount.text = worldstate.GetWater() + "";

        // enable and set info for panels depending on people in car
        string[] peopleInCar = worldstate.GetPeopleInCar();

        int i = 0; // manual counter bc im lazy
        foreach (CharacterPanel characterPanel in characterPanels)
        {
            characterPanel.IntializePanel(peopleInCar[i]);
            characterPanel.gameObject.SetActive(true);
            i++;
        }
    }


    // if isIncreasing is true, basically just means that the toggle is
    // being unclicked and the resource needs to be returned
    public void UpdateFood(bool isIncreasing)
    {
        // "returning" food, so positive numbers
        if (isIncreasing)
        {
            Debug.Log("food is increasing");
            worldstate.ChangeFood(1);
        }
        // "taking" food, so negative
        else if (!isIncreasing)
        {
            Debug.Log("food is decreasing");
            worldstate.ChangeFood(-1);
        }
        // updating the amt of food on the screen
        foodAmount.text = worldstate.GetFood() + "";
    }

    // if isIncreasing is true, basically just means that the toggle is
    // being unclicked and the resource needs to be returned
    public void UpdateWater(bool isIncreasing)
    {
        // "returning" water, so positive numbers
        if (isIncreasing)
        {
            Debug.Log("water is increasing");
            worldstate.ChangeWater(1);
        }
        // "taking" food, so negative
        else if (!isIncreasing)
        {
            Debug.Log("water is decreasing");
            worldstate.ChangeWater(-1);
        }
        // update the amount of water on the screen
        waterAmount.text = worldstate.GetWater() + "";
    }
}
