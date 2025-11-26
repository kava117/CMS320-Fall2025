using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CharacterPanel : MonoBehaviour
{
    [SerializeField] private NightPanelUI nightPanelUI;

    [Header("Components")]
    [SerializeField] private Toggle foodToggle;
    [SerializeField] private Toggle waterToggle;
    [SerializeField] private TextMeshProUGUI characterName;


    public void IntializePanel(string name)
    {
        characterName.text = name;
    }

    //public void SelectFoodToggle()
    //{
    //    foodToggle.Select();
    //    //nightPanelUI.updateFood();
    //}

    //public void UnselectFoodToggle()
    //{
    //    //foodToggle.OnDeselect();
    //    //nightPanelUI.updateFood();
    //}

    //public void SelectWaterToggle()
    //{
    //    waterToggle.Select();
    //    //nightPanelUI.updateWater();
    //}
}
