using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class CarMovement : MonoBehaviour
{
    public Transform navPoint;
    Transform[] points;
    private int destPoint = 0;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false;

        points = new Transform[12];

        navPoint = GameObject.Find("NavPoints").transform;

        for (int i = 0; i < navPoint.childCount; i++)
        {
            points[i] = navPoint.GetChild(i);
        }

        GotoNextPoint();
    }


    void GotoNextPoint()
    {
        destPoint = Random.Range(1, 12);

        if (points.Length == 0)
            return;        
        agent.destination = points[destPoint].position;
    }


    void Update()
    { 
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
            GotoNextPoint();
    }
}
