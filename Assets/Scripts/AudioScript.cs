using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    [Tooltip("This is where you can place your own music intro.")]
    public AudioClip introClip;

    [Tooltip("This is where you can place your own loop tracks. " +
        "If you have more than 3, make sure to adjust the size.")]
    public AudioClip[] mainLoopClips;
    public AudioSource musicSource;

    [Tooltip("This is where you can place your sound effects. " +
        "If you have more than 3, make sure to adjust the size.")]
    public AudioClip[] playerHitClips;
    public AudioSource sfxSource;

    // Start is called before the first frame update
    void Start()
    {
        musicSource.PlayOneShot(introClip);
        StartCoroutine(PlayMusicArray());
    }

    IEnumerator PlayMusicArray()
    {
        yield return new WaitForSecondsRealtime(introClip.length);

        while (true)
        {
            musicSource.clip = mainLoopClips[Random.Range(0, mainLoopClips.Length)];
            musicSource.Play();
            yield return new WaitForSecondsRealtime(mainLoopClips[0].length);
        }
    }

    public void PlayHitClips()
    {
        sfxSource.PlayOneShot(playerHitClips[Random.Range(0, playerHitClips.Length)]);
    }
}
