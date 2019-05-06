using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosiiton_Zone1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Player entered Zone 1");
        }
        else
        {
            Debug.Log("Player has not entered new zone");
        }
    }
}
