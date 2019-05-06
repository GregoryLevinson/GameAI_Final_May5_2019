using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCBlue : MonoBehaviour
{
    [SerializeField]
    GameObject NPCtoBeDestroyed;
    [SerializeField]
    GameObject NPCtoBeDestroyed2;
    [SerializeField]
    GameObject NPCtoBeDestroyed3;
    //[SerializeField]
    //GameObject NPCtoBeDestroyed4;
    //[SerializeField]
    //GameObject NPCtoBeDestroyed5;
    //[SerializeField]
    //GameObject NPCtoBeDestroyed6;
    //[SerializeField]
    //GameObject NPCtoBeDestroyed7;
    //[SerializeField]
    //GameObject NPCtoBeDestroyed8;
    private void Start()
    {
       
    }

    void OntriggerEnter(Collider other)
    {

            Destroy(NPCtoBeDestroyed.gameObject);
            Destroy(NPCtoBeDestroyed2.gameObject);
            Destroy(NPCtoBeDestroyed3.gameObject);
            NPCYellow.redDestroyed = true;

    }
}
