using UnityEngine;

public class SoundController : MonoBehaviour
{
    public static SoundController Instance;
//sources
    [SerializeField] public AudioSource sfxSource;
    [SerializeField] public AudioSource musicSource;

// sfx
    public AudioClip clickSound;
    public AudioClip menuSong;
    public AudioClip typing;
    public AudioClip stateMusic;


 

    private void Awake()
    {
        // Singleton pattern
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

    // --- SFX ---
    public void PlaySFX(AudioClip clip)
    {
        if (clip != null)
            sfxSource.PlayOneShot(clip);
    }


    public void PlayClick()
    {
        PlaySFX(clickSound);
    }



    // --- MUSIC ---
    public void PlayMusic(AudioClip music)
    {
        musicSource.clip = music;
        musicSource.Play();
       
    }

    public void StopMusic()
    {
        musicSource.Stop();
    }
}
