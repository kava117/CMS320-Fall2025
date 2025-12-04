using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CreditsBehavior : MonoBehaviour
{
    [SerializeField] private Button creditsButton;
    [SerializeField] private TextMeshProUGUI creditsButtonText;
    [SerializeField] private Canvas creditsUI;
    [SerializeField] private Button mainMenuButton;
    private bool areCreditsShowing = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        creditsButton.onClick.AddListener(DoCreditsThings);
    }

    private void OnDestroy()
    {
        creditsButton.onClick.RemoveListener(DoCreditsThings);
    }

    public void Awake()
    {
        creditsUI.gameObject.SetActive(false);
    }

    private void DoCreditsThings()
    {
        SoundController.Instance.PlayClick();
        // if credits are not currently on screen
        if (!areCreditsShowing)
        {
            Debug.Log("trying to show credits");
            creditsButtonText.text = "Return";
            mainMenuButton.gameObject.SetActive(false);
            creditsUI.gameObject.SetActive(true);
            areCreditsShowing = true;
        }
        else if (areCreditsShowing)
        {
            Debug.Log("trying to hide credits");
            creditsButtonText.text = "Credits";
            creditsUI.gameObject.SetActive(false);
            mainMenuButton.gameObject.SetActive(true);
            areCreditsShowing = false;
        }
    }
}
