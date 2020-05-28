using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackKeysScript : MonoBehaviour
{
    public float Yincrement = 0.01f;
    private Vector2 targetPos;

    AudioSource blackKeys;
    public AudioClip blackKeysClip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Keypad1)) //C#
        {
            GetComponent<AudioSource>().PlayOneShot(blackKeysClip);
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            transform.position = targetPos;
        }
        else if (Input.GetKey(KeyCode.Keypad3)) //D#
        {
            GetComponent<AudioSource>().PlayOneShot(blackKeysClip);
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            transform.position = targetPos;
        }
        else if (Input.GetKey(KeyCode.Keypad6)) //F#
        {
            GetComponent<AudioSource>().PlayOneShot(blackKeysClip);
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            transform.position = targetPos;
        }
        else if (Input.GetKey(KeyCode.Keypad8)) //G#
        {
            GetComponent<AudioSource>().PlayOneShot(blackKeysClip);
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            transform.position = targetPos;
        }
        else if (Input.GetKey(KeyCode.T)) //T=10, A#
        {
            GetComponent<AudioSource>().PlayOneShot(blackKeysClip);
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            transform.position = targetPos;
        }
    }
}
