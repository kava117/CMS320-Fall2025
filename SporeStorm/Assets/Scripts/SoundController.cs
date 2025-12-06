using UnityEngine;

public class SoundController : MonoBehaviour
{
    public static SoundController Instance;
//sources
    [SerializeField] public AudioSource sfxSource;
    [SerializeField] public AudioSource musicSource;

// sfx
    public AudioClip menuSong;
    public AudioClip typing;
    public AudioClip stateMusic;
    public AudioClip menuButton;
    public AudioClip badEnding;
    public AudioClip goodEnding;
    public AudioClip continueButton;
    public AudioClip mapButtons;





    private void Start()
    {
        string scene = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;

        if (scene == "MainMenu" || scene == "Narration")
            PlayMenuSong();

        if (scene == "Playing")
            PlayBackgroundMusic();
    }



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


    public void PlayContinueClick()
    {
        PlaySFX(continueButton);
    }

    public void PlayMapClick()
    {
        PlaySFX(mapButtons);
    }

    public void PlayClick()
    {
        PlaySFX(menuButton);
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



    public void PlayBadEndingSong()
    {
        StopMusic();

        PlayMusic(badEnding);
    }

    public void PlayGoodEndingSong()
    {
        StopMusic();

        PlayMusic(goodEnding);
    }




    public void PlayMenuSong()
    {
        if (musicSource.clip != menuSong)
        {
            PlayMusic(menuSong);
        }
        else if (!musicSource.isPlaying)
        {
            musicSource.Play();
        }
    }

    public void PlayBackgroundMusic()
    {
        PlayMusic(stateMusic);
    }





}
