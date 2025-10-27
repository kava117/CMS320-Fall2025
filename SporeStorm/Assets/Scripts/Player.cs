using UnityEngine;

/**
 * class to control the behavior of the player character
 * V1; 12.24.2024
 **/

public class Player : MonoBehaviour
{
    //from codemonkey tutorial 

    // variable to control the movement speed of the player
    //
    // serialize field is a way to make the private variable appear in
    // the unity editor (so i can use private instead of having
    // to use public). still not quite sure how 

    //[SerializeField] private GameInput gameInput;
    //[SerializeField] private InventoryUIManager inventoryUIManager;
    //[SerializeField] private SaveManager saveManager;




    private void Update()
    {
        //
        // --------------- DIALOGUE -----------------------------
        //

        // prevent button presses if in dialouge 
        if (DialogueController.Instance != null & DialogueController.Instance.IsInDialogue)
        {
            return;
        }
        //
        // ------------------------- INVENTORY -------------------------------
        //
        else if (Input.GetKeyDown(KeyCode.I))
        {
            //inventoryUIManager.ToggleInventory();
        }


        //
        // ------------------------ SAVE / LOAD --------------------------------
        //
        else if (Input.GetKeyDown(KeyCode.F5))
        {
            //saveManager.SaveGame();
        }

        else if (Input.GetKeyDown(KeyCode.F9))
        {
            //saveManager.LoadGame();
        }
    }
}