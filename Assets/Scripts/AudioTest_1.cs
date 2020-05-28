using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTest_1 : MonoBehaviour
{

    AudioSource explosionTest;
    public AudioClip testExplosionClip;

    // Start is called before the first frame update
    void Start()
    {
        explosionTest = GetComponent<AudioSource>();
    }

    public void AudioTestScript()
    {
        explosionTest.PlayOneShot(testExplosionClip);
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
