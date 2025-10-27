using UnityEngine;
using System.Collections.Generic;
using System.Security.Cryptography;

public class Worldstate : MonoBehaviour
{
    public static Worldstate Instance;

    private Dictionary<string, bool> flags = new Dictionary<string, bool>();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
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

    public Dictionary<string, bool> GetAllFlags()
    {
        // return a copy to protect internal state
        return new Dictionary<string, bool>(flags);
    }

    public void SetAllFlags(Dictionary<string, bool> loadedFlags)
    {
        flags = new Dictionary<string, bool>(loadedFlags);
    }

    //public List<FlagEntry> GetAllFlagsAsList()
    //{
    //    List<FlagEntry> entries = new();
    //    foreach (var kvp in flags)
    //    {
    //        entries.Add(new FlagEntry
    //        {
    //            key = kvp.Key,
    //            value = kvp.Value
    //        });
    //    }
    //    return entries;
    //}

    //public void SetAllFlagsFromList(List<FlagEntry> entries)
    //{
    //    flags.Clear();
    //    foreach (var entry in entries)
    //    {
    //        flags[entry.key] = entry.value;
    //    }
    //}
}
