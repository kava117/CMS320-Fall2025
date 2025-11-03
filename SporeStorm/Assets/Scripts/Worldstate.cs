using System.Collections.Generic;
using UnityEngine;

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
}
