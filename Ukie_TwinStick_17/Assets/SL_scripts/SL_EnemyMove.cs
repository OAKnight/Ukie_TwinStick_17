using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SL_EnemyMove : MonoBehaviour 
{
    private Vector3 mV3_TargetLocation;
    private GameObject mGO_PC;

    private NavMeshAgent mNM_agent;

	// Use this for initialization
	void Start () 
    {
        mGO_PC = GameObject.Find("PC");
        mNM_agent = GetComponent<NavMeshAgent>();

        InvokeRepeating("EnemyMove", 0.1f, 0.1f);
	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}

    void EnemyMove()
    {
        mV3_TargetLocation = mGO_PC.transform.position;

        mNM_agent.destination = mV3_TargetLocation;
    }
}
