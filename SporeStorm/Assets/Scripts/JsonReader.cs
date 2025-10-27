using System.Collections;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEditor.U2D.Animation;
using UnityEngine;




[System.Serializable]
public class Interaction
{
    public DialogueEvent[] dialogueEvents;
}


//[System.Serializable]
//public class InteractionList
//{
//    public Interaction[] interaction;
//}




public class JsonReader : MonoBehaviour
{
    public static readonly DialogueEvent FallbackEvent = new DialogueEvent
    {
        key = "default_debug",
        lines = new DialogueLine[]
        {
            new DialogueLine
            {
                text = "[No valid dialogue found. This is a debug fallback.]", expression = "default"
            }
        },
        conditions = new string[0],
        setFlags = new string[0]
    };



    public DialogueEvent GetDialogueEvent(CharacterData data)
    {
        if (data == null)
        {
            Debug.LogWarning("DialogueSelector: CharacterData is null");
            return JsonReader.FallbackEvent;
        }

        string npcName = data.internalName;
        TextAsset jsonFile = Resources.Load<TextAsset>($"Data/Dialogue/{npcName}Dialogue");
        DialogueEventList eventList = JsonUtility.FromJson<DialogueEventList>(jsonFile.text);

        if (jsonFile == null)
        {
            Debug.LogError($"Dialogue file not found for NPC: {npcName}");
            return JsonReader.FallbackEvent;
        }

        // find the event with matching conditions
        var match = eventList.dialogueEvents
            .Where(evt => evt != null && HasAllConditions(evt.conditions, data))
            .OrderByDescending(evt => evt.conditions?.Length ?? 0)
            .FirstOrDefault();

        //if (match != null)
        //{
        //    Debug.Log($"[JsonReader] Selected event: {match.key}");
        //}
        //else
        //{
        //    Debug.LogWarning("[JsonReader] No matching event found. Using fallback.");
        //}

        return match != null ? match : JsonReader.FallbackEvent;
    }

    private static bool HasAllConditions(string[] conditions, CharacterData data)
    {
        if (conditions == null || conditions.Length == 0)
        {
            return true;
        }

        foreach (string condition in conditions)
        {
            if (condition.StartsWith("npc:"))
            {
                string key = condition.Substring(4);
                if (!data.flags.TryGetValue(key, out bool value) || !value)
                {
                    return false;
                }
            }
            else
            {
                if (!Worldstate.Instance.HasFlag(condition))
                {
                    return false;
                }
                else
                {
                    if (Worldstate.Instance == null)
                    {
                        Debug.LogError("Worldstate.Instance is null.");
                        return false;
                    }
                    if (!Worldstate.Instance.HasFlag(condition))
                    {
                        return false;
                    }
                }
            }
        }

        return true;
    }







    // loads the dialogue JSON file for the specific NPC
    //public DialogueEvent GetDialogueEventByNameAndEvent(string npcName, string eventKey)
    //{
    //    // expected file path format: Resources/Data/Dialogue/JuneDialogue.json
    //    TextAsset jsonFile = Resources.Load<TextAsset>($"Data/Dialogue/{npcName}Dialogue");

    //    if (jsonFile == null)
    //    {
    //        Debug.LogError($"Dialogue file not found for NPC: {npcName} at path: Data/Dialogue/{npcName}Dialogue");
    //        return null;
    //    }

    //    DialogueEventList eventList = JsonUtility.FromJson<DialogueEventList>(jsonFile.text);
    //    if (eventList == null || eventList.dialogueEvents == null)
    //    {
    //        Debug.LogError($"DialogueEventList for {npcName} could not be parsed or was empty.");
    //        return null;
    //    }

    //    // look for matching event
    //    var matches = eventList.dialogueEvents
    //        .Where(evt => evt != null && evt.key == eventKey)
    //        .OrderByDescending(evt => evt.conditions != null ? evt.conditions.Length : 0);

    //    foreach (var evt in matches)
    //    {
    //        if (evt.conditions == null || evt.conditions.Length == 0 ||
    //            Worldstate.Instance.HasAllFlags(evt.conditions.ToList()))
    //        {
    //            return evt;
    //        }
    //    }

    //    Debug.LogWarning($"No dialogue found for {npcName} under event '{eventKey}'.");
    //    return null;
    //}
}
