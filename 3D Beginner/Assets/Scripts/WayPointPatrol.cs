﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WayPointPatrol : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Transform[] waypoints;
    

    int m_CurrentWaypointIndex;

    void Start()
    {
        gargoyle enemy = gameObject.GetComponent("Gargoyle");
        navMeshAgent.SetDestination(waypoints[0].position);
    }

    void Update()
    {
        if(navMeshAgent.remainingDistance < navMeshAgent.stoppingDistance)
        {
            m_CurrentWaypointIndex = (m_CurrentWaypointIndex + 1) % waypoints.Length;
            navMeshAgent.SetDestination (waypoints[m_CurrentWaypointIndex].position);
        }
    }

    void ObserverCaught()
    {
         navMeshAgent.SetDestination(gargoyle.transform.position);
         
    }
}
