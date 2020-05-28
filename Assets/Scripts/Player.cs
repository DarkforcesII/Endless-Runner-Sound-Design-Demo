using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MidiJack;
using UniOSC;
using OSCsharp.Data;

public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    public float Yincrement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || MidiDriver.Instance.GetKeyDown(MidiChannel.All, 67))
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            transform.position = targetPos;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) || MidiDriver.Instance.GetKeyDown(MidiChannel.All, 68))
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            transform.position = targetPos;
        }

        //midi controls
        if (Input.GetKey(KeyCode.Space))
        {

        }
    }
}
