using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCGray : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 0;
    [SerializeField]
    float waitTime = 0;
    [SerializeField]
    float startWaitTime = 0;


    [SerializeField]
    Transform[] spotsToMoveTo;
    private int randomSpot;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = startWaitTime;
        randomSpot = Random.Range(0, spotsToMoveTo.Length);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, 
            spotsToMoveTo[randomSpot].position, moveSpeed*Time.deltaTime);

        if(Vector3.Distance(transform.position, spotsToMoveTo[randomSpot].position) < 0.2f)
        {
            if (waitTime <= 0)
            {
                randomSpot = Random.Range(0, spotsToMoveTo.Length);
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }

    }
}
