using UnityEngine;
using System.Collections.Generic;

public class NPCManager : MonoBehaviour
{
    // expose all loaded character data
    public Dictionary<string, CharacterData> AllCharacterData => npcDict;


    public static NPCManager Instance
    {
        get; private set;
    }

    private Dictionary<string, CharacterData> npcDict = new Dictionary<string, CharacterData>();

    public IReadOnlyDictionary<string, CharacterData> AllCharacters => npcDict;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject); // prevents duplicates
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject); //optional, this keeps character data across scenes

        LoadAllCharacterData();
    }

    private void LoadAllCharacterData()
    {
        npcDict.Clear();

        TextAsset[] files = Resources.LoadAll<TextAsset>("Data/NPCs");

        foreach (var file in files)
        {
            CharacterData data = JsonUtility.FromJson<CharacterData>(file.text);
            if (data != null && !string.IsNullOrEmpty(data.internalName))
            {
                npcDict[data.internalName] = data;
                Debug.Log($"[CharacterManager] Loaded: {data.internalName}");
            }
            else
            {
                Debug.LogWarning($"[CharacterManager] Failed to load or name missing in file: {file.name}");
            }
        }
    }

    public CharacterData GetCharacterData(string internalName)
    {
        if (npcDict.TryGetValue(internalName, out var data))
        {
            return data;
        }

        Debug.LogWarning($"[CharacterManager] No character found with name: {internalName}");
        return null;
    }
}
