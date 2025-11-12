using System.IO;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class JsonReader : MonoBehaviour
{
    // creates a debug dialogueEvent that can be used in case there is some issue
    // but the code still must run
    public static DialogueEvent FallbackEvent = new DialogueEvent
    {
        key = "default_fallback",
        lines = new DialogueLine[]
        {
            new DialogueLine
            {
                text = "NO VALID DIALOGUE/CHARACTERDATA NULL. THIS IS DEBUG FALLBACK.", expression = "default"
            }
        },
        conditions = new string[0],
        setFlags = new string[0]
    };

    public DialogueEvent GetDialogueEvent(CharacterData data)
    {
        if (data == null)
        {
            Debug.LogWarning("JsonReader: CharacterData is null");
            return JsonReader.FallbackEvent;
        }

        // load dialogue file
        string npcName = data.internalName;
        TextAsset jsonFile = Resources.Load<TextAsset>($"Data/Dialogue/{npcName}Dialogue");
        DialogueEventList eventList = JsonUtility.FromJson<DialogueEventList>(jsonFile.text);

        // find the event w correct conditions/key
        var match = eventList.dialogueEvents
            .Where(evt => evt != null && HasAllConditions(evt.conditions, data))
            .OrderByDescending(evt => evt.conditions?.Length ?? 0)
            .FirstOrDefault();

        return match != null ? match : JsonReader.FallbackEvent;
    }

    // checks if an event satisfies all currently set flags (ex: what day is it? how much fuel?)
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
                        Debug.LogError("Worldstate.Instance is null");
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
}
