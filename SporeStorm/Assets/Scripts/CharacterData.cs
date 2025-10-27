using System;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

[System.Serializable]
public class CharacterData
{
    public string internalName;
    public string displayName;
    public string portraitPath;
    public string voiceEffect;
    public string dialogueFile;

    public int hunger;
    public int happiness;
    public int health;
    public Boolean healthy;

    public Dictionary<string, bool> flags = new Dictionary<string, bool>();

    [System.Serializable]
    public class ScheduleEntry
    {
        public string time;
        public string location;
    }

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

    //public List<FlagEntry> ToFlagList()
    //{
    //    var list = new List<FlagEntry>();
    //    foreach (var kvp in flags)
    //    {
    //        list.Add(new FlagEntry
    //        {
    //            key = kvp.Key,
    //            value = kvp.Value
    //        });
    //    }

    //    Debug.Log($"{internalName} has {list.Count} flags to save.");
    //    return list;
    //}

    //public void LoadFlagsFromList(List<FlagEntry> flagList)
    //{
    //    flags.Clear();
    //    foreach (var entry in flagList)
    //    {
    //        flags[entry.key] = entry.value;
    //    }
    //}






    //[System.Serializable]
    //public class ScheduleEntryGroup
    //{
    //    public string key;
    //    public string day;
    //    public List<ScheduleEntry> value;
    //}

    //[System.Serializable]
    //public class StringIntPair
    //{
    //    public string key;
    //    public int value;
    //}

    //[System.Serializable]
    //public class StringBoolPair
    //{
    //    public string key;
    //    public bool value;
    //}
}
