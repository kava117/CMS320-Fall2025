using UnityEngine;
using System;

[System.Serializable]
public class DialogueEvent
{
    public string key;
    public string[] conditions;
    public DialogueLine[] lines;
    public string[] setFlags;
}
