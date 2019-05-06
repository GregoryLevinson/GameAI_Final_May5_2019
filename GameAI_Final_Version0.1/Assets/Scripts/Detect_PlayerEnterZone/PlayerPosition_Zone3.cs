using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition_Zone3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Player entered Zone 3");
        }
        else
        {
            Debug.Log("Player has not entered new zone");
        }
    }
}
