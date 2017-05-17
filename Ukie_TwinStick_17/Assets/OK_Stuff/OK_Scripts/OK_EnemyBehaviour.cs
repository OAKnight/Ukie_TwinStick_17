using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class OK_EnemyBehaviour : MonoBehaviour {

    // public variables to control range and movement of enemy

        // list of game objects needed
    public GameObject Go_Arrow;
    public GameObject Go_Sword;
    public GameObject Go_Sword1;
    public GameObject Go_Horse;
    public GameObject Go_Horse1;

    public GameObject Go_mm;


    public GameObject Go_target;

    //list of floats needed
    private float fl_att_dis = 30;
    private float fl_arr_dis = 70;
    private float fl_active;

    private bool bl_stop;

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        NPC_Move();
        TargetSelect();

        if (Go_target == Go_mm)
        {
            fl_active = 1;

        }
        else
        {
            fl_active = 2;
        }

    }//-----

    // ----------------------------------------------------------------------
    void NPC_Move()

    {
        transform.Translate(Vector3.forward * fl_active* Time.deltaTime);
        if (Go_target == null)
        {

            bl_stop = true;
        }


        // Is the target in Range
        if (Vector3.Distance(transform.position, Go_target.transform.position) < fl_att_dis)
            {

                // Move towards the target
                if (bl_stop == false)
                    {
                        transform.LookAt(Go_target.transform.position);
                    }
                else
                    { }



        }

    }//-----
    void TargetSelect()
    {

        if (Vector3.Distance(transform.position, Go_Sword.transform.position) < fl_att_dis)
        {
            Go_target = Go_Sword;

        }
        else if (Vector3.Distance(transform.position, Go_Sword1.transform.position) < fl_att_dis)
        {
            Go_target = Go_Sword1;

        }
        else if (Vector3.Distance(transform.position, Go_Horse.transform.position) < fl_att_dis)
        {
            Go_target = Go_Horse;

        }
        else if (Vector3.Distance(transform.position, Go_Horse1.transform.position) < fl_att_dis)
        {
            Go_target = Go_Horse1;

        }

        else if (Vector3.Distance(transform.position, Go_Arrow.transform.position) < fl_arr_dis)
        {

            Go_target = Go_Arrow;

        }
    }
    void OnTriggerEnter(Collider cl_trigger)
    {
        if (cl_trigger.gameObject == Go_target)
        {
            bl_stop = false;

        }

    }
    void OnTriggerExit(Collider cl_trigger)
    {
        if (cl_trigger.gameObject == Go_target)
        {
            bl_stop = true;

        }
    }
}//==========

