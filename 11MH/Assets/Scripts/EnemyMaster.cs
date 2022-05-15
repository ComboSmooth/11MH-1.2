using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMaster : MonoBehaviour
{
    public GameObject Player;
    public float Distance;

    public bool isAngered;

    public NavMeshAgent _agent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Distance = Vector3.Distance(Player.transform.position, this.transform.position);


        if(Distance <= 5f)
        {
            isAngered = true;
        }
        if(Distance > 5f)
        {
            isAngered = false;
        }

        if (isAngered)
        {
            _agent.isStopped = false ;
            _agent.SetDestination(Player.transform.position);
        }
        else
        {
            _agent.isStopped = true;
        }
    }
}
