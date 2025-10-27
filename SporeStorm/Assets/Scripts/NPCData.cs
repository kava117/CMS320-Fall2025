using UnityEngine;
using System.IO;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

public class NPC : MonoBehaviour
{
    [SerializeField] private Sprite defaultPortrait;
    [SerializeField] private List<ExpressionSprite> expressions;

    private string characterDataFile;
    private CharacterData characterData;
    private Dictionary<string, Sprite> expressionDict;


    private void Awake()
    {
        if (string.IsNullOrEmpty(characterDataFile))
        {
            characterDataFile = $"Data/NPCs/{gameObject.name}Data";
        }

        Debug.Log($"Trying to load character data at: {characterDataFile}.");

        LoadCharacterData();
        expressionDict = expressions.ToDictionary(e => e.key, e => e.sprite);

        if (characterData != null)
        {
            Debug.Log($"AWAKE: Loaded character data for {characterData.displayName}");
        }
        else
        {
            Debug.LogError($"AWAKE: Failed to load character data for {characterDataFile}");
        }
    }

    public Sprite GetExpression(string key)
    {
        if (expressionDict.TryGetValue(key, out Sprite result))
        {
            return result;
        }
        return defaultPortrait;
    }

    [System.Serializable]
    public class ExpressionSprite
    {
        public string key;
        public Sprite sprite;
    }

    public string GetNPCName()
    {
        return characterData != null ? characterData.displayName : "[Unknown]";
    }

    public Sprite GetDefaultPortrait()
    {
        return defaultPortrait;
    }

    public CharacterData GetCharacterData()
    {
        return characterData;
    }

    private void LoadCharacterData()
    {

        Debug.Log($"Trying to load character data at: {characterDataFile}");

        // if the field is empty, auto-generate it
        if (string.IsNullOrEmpty(characterDataFile))
        {
            characterDataFile = $"Data/NPCs/{gameObject.name}Data";
        }

        TextAsset json = Resources.Load<TextAsset>(characterDataFile);

        if (json != null)
        {
            characterData = JsonUtility.FromJson<CharacterData>(json.text);
        }
        else
        {
            Debug.LogError($"Failed to load character data for {characterDataFile}");
        }

        if (characterData != null)
        {
            Debug.Log($"LOADDATA: Loaded character data for {characterData.displayName}");
        }
        else
        {
            Debug.LogError($"LOADDATA: Failed to load character data for {characterDataFile}");
        }
    }
}
