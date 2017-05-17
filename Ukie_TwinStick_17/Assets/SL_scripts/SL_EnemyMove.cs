using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SL_EnemyMove : MonoBehaviour 
{
    //change
    private Vector3 mV3_TargetLocation;
    private GameObject mGO_PC;

    private NavMeshAgent mNM_agent;

    private SL_GameManager mSCR_gameManager;

    //public variables
    public float mFL_MovementSpeed;
    public float mFL_AttackSpeed;

	// Use this for initialization
	void Start () 
    {
        mGO_PC = GameObject.Find("PC");
        mNM_agent = GetComponent<NavMeshAgent>();

        mSCR_gameManager = GameObject.Find("GameManager").GetComponent<SL_GameManager>();

        InvokeRepeating("EnemyMove", 0.1f, 0.1f);

        InvokeRepeating("AttackPlayer", mFL_AttackSpeed, mFL_AttackSpeed);

        mNM_agent.speed = mFL_MovementSpeed;
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

    void AttackPlayer()
    {
        print(Vector3.Distance(gameObject.transform.position, mGO_PC.transform.position) <= 2f);
        if (Vector3.Distance(gameObject.transform.position, mGO_PC.transform.position) <= 2f)
        {
            mSCR_gameManager.mIN_playerHP -= 1;

            mSCR_gameManager.DrawHearts();
        }
    }
}
