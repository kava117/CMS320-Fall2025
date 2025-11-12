using UnityEngine;

public class Scene : MonoBehaviour
{
    [SerializeField] private GameEventsManager manager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("fetching dialogue");
        GameEventsManager.instance.dialogueEvents.EnterDialogue("Jane");
        Debug.Log("running dialogue");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
