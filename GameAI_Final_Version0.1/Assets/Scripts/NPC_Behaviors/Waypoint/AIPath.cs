using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Path : MonoBehaviour {

	  [SerializeField]
    Transform[] path;

    [SerializeField]
    float speed = 5.0f;

    [SerializeField]
    float reachdistance = 1.0f;

    [SerializeField]
    int currentpoints = 0;

    // Use this for initialization
    void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        //Vector3 direction = path[currentpoints].position - transform.position;
        //transform.position += direction * Time.deltaTime * speed;

        //if(dist.magnitude <= reachdistance) 
        //{
        //    currentpoints++;
        //}

        //if(currentpoints >= path.length)
        //{
        //    currentpoints = 0;
        //}

        float dist = Vector3.Distance(path[currentpoints].position, transform.position);

        transform.position = Vector3.MoveTowards(transform.position,path[currentpoints].position, Time.deltaTime * speed);
        
        if(dist <= reachdistance)
        {
            currentpoints++;
        }

        if (currentpoints >= path.Length)
        {
            currentpoints = 0;
        }

    }


    private void OnDrawGizmos()
    {
        if(path.Length > 0)
        {
            for (int i = 0; i < path.Length; i++)
            {
                if (path[i] != null)
                {
                    Gizmos.DrawSphere(path[i].position, reachdistance);
                }
            }
        }
  
    }
}
