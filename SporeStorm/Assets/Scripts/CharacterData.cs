using System;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

[System.Serializable]
public class CharacterData
{
    // references for ui/dialogue things
    public string internalName;
    public string displayName;
    public string portraitPath;
    public string voiceEffect;
    public string dialogueFile;

    // list of all "flags" associated w a character 
    // aka whether they have been met, killed, etc.
    public Dictionary<string, bool> flags = new Dictionary<string, bool>();

    // dynamic stats, will change throughout the game
    public int hunger;
    public int stress;
    public int health;
    public Boolean sick;

    

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
}
