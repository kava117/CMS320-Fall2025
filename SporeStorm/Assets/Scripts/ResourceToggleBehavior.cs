using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ResourceToggle : MonoBehaviour
{
    [SerializeField] private Toggle toggle;
    [SerializeField] private NightPanelUI nightPanelUI;


    private void OnEnable()
    {
        toggle.onValueChanged.AddListener(UpdateValue);
    }

    private void OnDisable()
    {
        toggle.onValueChanged.RemoveListener(UpdateValue);
    }

    private void UpdateValue(bool arg0)
    {
        Debug.Log("toggle behavior: trying to update value");
        // if toggle is actively clicked
        if (arg0)
        {
            // if its a food toggle
            if (toggle.name[0] == 'F')
            {
                nightPanelUI.UpdateFood(false);
            }
            // if its a water toggle
            else if (toggle.name[0] == 'W')
            {
                nightPanelUI.UpdateWater(false);
            }
        }
        // if toggle is not clicked
        else if (!toggle.isOn)
        {
            // if its a food toggle
            if (toggle.name[0] == 'F')
            {
                nightPanelUI.UpdateFood(true);
            }
            // if its a water toggle
            else if (toggle.name[0] == 'W')
            {
                nightPanelUI.UpdateWater(true);
            }
        }
    }

}
