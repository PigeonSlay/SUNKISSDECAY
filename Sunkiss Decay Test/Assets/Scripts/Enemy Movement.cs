using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{

    public float moveSpeed, distanceToStop;
    public Rigidbody theRigidbody;

    private Vector3 target;
    public NavMeshAgent agent;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        target.y = transform.position.y;

        agent.destination = target;
        
        //transform.LookAt(target);
        //theRigidbody.linearVelocity = transform.forward * moveSpeed;

       if (Vector3.Distance(theRigidbody.position, target) > distanceToStop)
        {
            agent.destination = target;
        }
        else
        {
            agent.destination = transform.position;
        }
        
    }
}
