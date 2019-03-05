using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance { get; private set; }
    public AudioSource BGMPlayer, SFXPlayer;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    public void PlaySFX(string clip)
    {
        PlaySFX(clip, Random.Range(0.3f, 1f));
    }

    public void PlaySFX(string clip, float volume)
    {
        AudioClip audioClip = Resources.Load($"Audio/{clip}") as AudioClip;
        SFXPlayer.PlayOneShot(audioClip, volume);
    }
}
