using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public AudioSource bgMusic;
    private float lastVolume = 1f;
    public bool isMuted = false;

    void Awake()
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

    public void SetVolume(float volume)
    {
        if (!isMuted)
        {
            bgMusic.volume = volume;
            lastVolume = volume;
        }
    }

    public void ToggleMute()
    {
        if (isMuted)
        {
            bgMusic.volume = lastVolume;
            isMuted = false;
        }
        else
        {
            lastVolume = bgMusic.volume;
            bgMusic.volume = 0f;
            isMuted = true;
        }
    }

    public float GetVolume()
    {
        return bgMusic.volume;
    }
}