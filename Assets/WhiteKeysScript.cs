using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteKeysScript : MonoBehaviour
{

    public float Yincrement;
    private Vector2 targetPos;

    AudioSource whiteKeys;
    public AudioClip whiteKeysClip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.C))
        {
            GetComponent<AudioSource>().PlayOneShot(whiteKeysClip);
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            transform.position = targetPos;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            GetComponent<AudioSource>().PlayOneShot(whiteKeysClip);
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            transform.position = targetPos;
        }
        else if (Input.GetKey(KeyCode.E))
        {
            GetComponent<AudioSource>().PlayOneShot(whiteKeysClip);
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            transform.position = targetPos;
        }
        else if (Input.GetKey(KeyCode.F))
        {
            GetComponent<AudioSource>().PlayOneShot(whiteKeysClip);
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            transform.position = targetPos;
        }
        else if (Input.GetKey(KeyCode.G))
        {
            GetComponent<AudioSource>().PlayOneShot(whiteKeysClip);
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            transform.position = targetPos;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            GetComponent<AudioSource>().PlayOneShot(whiteKeysClip);
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            transform.position = targetPos;
        }
        else if (Input.GetKey(KeyCode.B))
        {
            GetComponent<AudioSource>().PlayOneShot(whiteKeysClip);
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            transform.position = targetPos;
        }
    }
}
