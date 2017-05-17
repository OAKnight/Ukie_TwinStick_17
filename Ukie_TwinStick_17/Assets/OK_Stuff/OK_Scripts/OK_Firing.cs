using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OK_Firing : MonoBehaviour {

    public GameObject GO_bullet;

    private float fl_speed;
    public float fl_time;
    private bool bl_load = true;
    

    void Start()
    {
        fl_speed = fl_time;

    }
    
    void Update()
    {
        Fire();
        SpTime();


    }//---

    void Fire()
    {

        if (gameObject.tag == "Player1")
        {
            if (bl_load == true)
            {
                if (Input.GetAxis("Right_Trigger1") < 0)
                {
                    Instantiate(GO_bullet, transform.position + transform.TransformDirection(new Vector3(0, 0, 2F)), transform.rotation);
                    bl_load = false;
                }
            }
        }

        if (gameObject.tag == "Player2")
        {

            if (bl_load == true)
            {
                if (Input.GetAxis("Right_Trigger2") < 0)
                {
                    Instantiate(GO_bullet, transform.position + transform.TransformDirection(new Vector3(0, 0, 2F)), transform.rotation);
                    bl_load = false;

                }
            }
        }       

    }//---

    void SpTime()
    {

        if (bl_load == false)
        {
            fl_speed -= Time.deltaTime;
        }

        if (fl_speed <= 0)
        {
            bl_load = true;
            fl_speed = fl_time;
        }

    }
}
 