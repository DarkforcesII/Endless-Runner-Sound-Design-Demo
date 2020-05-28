using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainTheme : MonoBehaviour
{

    public AudioClip[] mainThemeArray;
    AudioSource mainTheme;

    // Start is called before the first frame update
    void Start()
    {
        mainTheme = GetComponent<AudioSource>();
        StartCoroutine(WaitAndExecute());
    }

    IEnumerator WaitAndExecute()
    {
        yield return new WaitForSecondsRealtime(5.333f);

        while (true)
        {
            mainTheme.clip = mainThemeArray[Random.Range(0, mainThemeArray.Length)];
            mainTheme.Play();
            yield return new WaitForSecondsRealtime(10.666f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
