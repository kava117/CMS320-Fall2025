using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NightPanelUI : MonoBehaviour
{
    [SerializeField] private Worldstate worldstate;

    [SerializeField] private ResourceButton[] resourceButtons;

    [SerializeField] private GameObject contentParent;
    [SerializeField] private TextMeshProUGUI dayComplete;
    [SerializeField] private TextMeshProUGUI recapText;

    [SerializeField] private TextMeshProUGUI foodAmount;
    [SerializeField] private TextMeshProUGUI waterAmount;

    [SerializeField] private TextMeshProUGUI characterName;

    
    // Update is called once per frame
    void Update()
    {
        
    }


}
