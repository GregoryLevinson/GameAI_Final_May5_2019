using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestroy_RED : MonoBehaviour
{
    [SerializeField]
    GameObject sphereRED;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(sphereRED);
            Debug.Log("RED Sphere Destroyed!!");
        }
    }

}
