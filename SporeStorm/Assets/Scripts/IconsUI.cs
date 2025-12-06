using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class IconsUI : MonoBehaviour
{
    [SerializeField] Worldstate worldstate;
    [SerializeField] GameObject contentParent;
    [SerializeField] private TextMeshProUGUI gas;
    [SerializeField] private TextMeshProUGUI inventory;
    [SerializeField] private TextMeshProUGUI hours;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        contentParent.SetActive(true);
        UpdateIcons();
    }

    

    public void UpdateIcons()
    {
        gas.text = worldstate.GetFuel() + "";
        inventory.text = worldstate.GetWater() + "";
        hours.text = worldstate.GetHoursLeft() + "";
    }
}
