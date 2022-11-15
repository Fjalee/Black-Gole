using UnityEngine;

public class BackgroundMusicManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource _music1;

    [SerializeField]
    private AudioSource _music2;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        PlayMainMusic();

        var randInt = Random.Range(1, 10);
        if (randInt == 10)
        {
            PlayWhaleMusic();
        }
    }

    public void PlayWhaleMusic()
    {
        PlayMusic(_music2);
    }
    public void StopWhaleMusic()
    {
        StopMusic(_music2);
    }

    public void PlayMainMusic()
    {
        PlayMusic(_music1);
    }
    public void StopMainMusic()
    {
        StopMusic(_music1);
    }

    private void PlayMusic(AudioSource music)
    {
        if (music.isPlaying) return;
        music.Play();
    }

    private void StopMusic(AudioSource music)
    {
        music.Stop();
    }
}
