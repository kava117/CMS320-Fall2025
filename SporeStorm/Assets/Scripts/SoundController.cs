using UnityEngine;

public class SoundController : MonoBehaviour
{

    public static SoundController Instance; 

    [SerializeField] private AudioSource MenuMusic;
    [SerializeField] private AudioSource Typing; 


    public void PlayMenu(AudioClip clip)
    {
        MenuMusic.clip = clip;
        MenuMusic.Play();
    }

    public void PlayTyping(AudioClip clip)
    {
        Typing.clip = clip;
        Typing.Play();
    }


}
