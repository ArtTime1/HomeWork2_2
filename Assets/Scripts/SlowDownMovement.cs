using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SlowDownMovement : MonoBehaviour
{
    [SerializeField] NavMeshAgent meshAgent;
    private float startSpeed;

    private void Start()
    {
        startSpeed = meshAgent.speed;
    }
    private void OnTriggerEnter(Collider other)
    { 
        if(other.CompareTag("Player")) 
        {
            meshAgent.speed = meshAgent.speed * 0.5f;
        }     
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            meshAgent.speed = startSpeed;
        }                
    }
}
