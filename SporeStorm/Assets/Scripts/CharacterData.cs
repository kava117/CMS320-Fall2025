using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


/**
 * SPORESTORM
 * manages character object creation and backend information. all interactions w the
 * characters are called and managed from npc class
 */
[System.Serializable]
public class CharacterData
{
    // backend references
    public string internalName;
    public string displayName;
    public string portraitPath;
    public string voiceEffect;
    public string dialogueFile;

    // dynamic stats, will change throughout the game
    public int hunger;
    public int stress;
    public int health;
    public bool sick;

    // list of all "flags" associated w a character 
    // aka whether they have been met, killed, etc.
    [System.NonSerialized] public Dictionary<string, bool> flags; // <-- runtime dictionary
    public List<FlagEntry> flagsList; // <-- ONLY for serialization


    public void SetFlag(string flag, bool value)
    {
        if (flag == null)
        {
            Debug.Log($"No flag found to update.");
            return;
        }

        flags[flag] = value;

        Debug.Log($"Flag set: {flag} = {value}");
    }

    public bool HasFlag(string flag)
    {
        return flags.TryGetValue(flag, out bool value) && value;
    }

    public bool HasAllFlags(List<string> requiredFlags)
    {
        foreach (var flag in requiredFlags)
        {
            if (!HasFlag(flag))
            {
                return false;
            }
        }
        return true;
    }


    // converting the LIST that jsonreader makes into a DICTIONARY
    public void InitializeDictionaries()
    {
        flags = flagsList.ToDictionary(f => f.key, f => f.value);
    }
}

// for initializing the lists to be converted into dictionaries
public class FlagEntry
{
    public string key;
    public bool value;
}
