using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_AudioForPlayerEnterZone2 : MonoBehaviour
{
    [SerializeField]
    AudioSource zone2audio;
    [SerializeField]
    AudioSource red;

    // Start is called before the first frame update
    void Start()
    {
        zone2audio.GetComponent<AudioSource>();
        red.GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Audio for Zone_2_ Played");
            zone2audio.Play();
            red.Play();
        }
        else
        {
            Debug.Log("Audio for Zone_2_ Idle");
        }
    }
    void OnTriggerExit(Collider other)
    {
        red.Stop();
    }
}
