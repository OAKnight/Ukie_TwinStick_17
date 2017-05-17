 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OK_Damage : MonoBehaviour
{

    public float fl_Hp;
    public bool bl_arrow = false;
    public bool bl_sword = false;
    public bool bl_horse = false;


    public float fl_sword = 0;
    public float fl_arrow = 0;
    public float fl_horse = 0;
    public float fl_player = 0;
    public float fl_arrows;
    public float fl_time;
    public float fl_countdown = 4;

    // Use this for initialization
    void Start()
    {
        fl_Hp = 50;
        fl_sword = 0;
        fl_arrow = 0;
        fl_horse = 0;
        fl_player = 0;
        fl_arrows = 0;

    }

    // Update is called once per frame
    void Update()
    {


        if (fl_Hp < 0)
        {
            gameObject.SetActive(false);

        }

        fl_Hp -= fl_arrow + fl_horse + fl_sword + fl_player+ fl_arrows;
        fl_time -= Time.deltaTime;


    }
    public void OnTriggerEnter(Collider cl_trigger)
    {


        if (gameObject.tag == "Enemy1" && cl_trigger.gameObject.tag == "Arrow")
        {
            fl_arrow = 1 * Time.deltaTime;

        }
        if (gameObject.tag == "Enemy1" && cl_trigger.gameObject.tag == "Sword")
        {
            fl_sword = 2 * Time.deltaTime;

        }
        if (gameObject.tag == "Enemy1" && cl_trigger.gameObject.tag == "Horse")
        {
            fl_horse = 2.5f * Time.deltaTime;

        }
        if ((gameObject.tag == "Player" || gameObject.tag == "Selected") && cl_trigger.gameObject.tag == "Enemy")
        {
            fl_player = 1.5f * Time.deltaTime;

        }
        if (fl_time < 0)
        {
            if (cl_trigger.gameObject.tag == "Projectile")
            {

                fl_arrows = 4 * Time.deltaTime;
                fl_time = fl_countdown;

            }
        }




    }
    public void OnTriggerExit(Collider cl_Exit)
    {

        if (cl_Exit.gameObject.tag == "Arrow")
        {
            fl_arrow = 0;

        }
        if (cl_Exit.gameObject.tag == "Sword")
        {
            fl_sword = 0;

        }
        if (cl_Exit.gameObject.tag == "Horse")
        {
            fl_horse = 0;

        }
        if (cl_Exit.gameObject.tag == "Enemy")
        {
            fl_player = 0;

        }
        if (cl_Exit.gameObject.tag == "Projectile")
        {
            fl_arrows = 0;

        }
        

    }
    public void HealthUp()
    {
        fl_Hp = fl_Hp + 10;
    }
}