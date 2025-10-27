using UnityEngine;
using System;

[System.Serializable]
public class DialogueEvent
{
    public string key;
    public DialogueLine[] lines;
    public string[] conditions;
    public string[] setFlags;
}
