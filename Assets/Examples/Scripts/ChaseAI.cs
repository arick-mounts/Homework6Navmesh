using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


[RequireComponent(typeof(NavMeshAgent))]

public class ChaseAI : MonoBehaviour
{
    NavMeshAgent m_Agent;
    public Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        m_Agent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        m_Agent.destination = Player.position;
    }
}
