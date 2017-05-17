using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM_Player_Speed : MonoBehaviour
{

    public float fl_SpeedH;
    public float fl_SpeedV;
    public float fl_time;
    public float fl_duration = 20;

    // Update is called once per frame
    void Update()
    {
        Control();
    }

    void Control()
    {

        if (gameObject.tag == "Player1")
        {
            // Left analog controls to move the PC within the space

            float transV = Input.GetAxis("Vertical") * fl_SpeedV;
            float transH = Input.GetAxis("Horizontal") * fl_SpeedH;
            transV *= Time.deltaTime;
            transH *= Time.deltaTime;
            transform.position += new Vector3(0, 0, transV);
            transform.position += new Vector3(transH, 0, 0);

            // Right analog stick, this is used to control the player facing.
            float fl_rightx = Input.GetAxis("Right_Hor1");
            float fl_righty = Input.GetAxis("Right_Vert1");

            float fl_angler = Mathf.Atan2(fl_rightx, fl_righty);

            transform.rotation = Quaternion.EulerAngles(0, fl_angler, 0);

            if (transH == 0 && transV == 0)
            {
                transform.position = transform.position;

            }

        }

        if (gameObject.tag == "Player2")
        {
            // Left analog controls to move the PC within the space

            float transV = Input.GetAxis("Vertical2") * fl_SpeedV;
            float transH = Input.GetAxis("Horizontal2") * fl_SpeedH;
            transV *= Time.deltaTime;
            transH *= Time.deltaTime;
            transform.position += new Vector3(0, 0, transV);
            transform.position += new Vector3(transH, 0, 0);

            // Right analog stick, this is used to control the player facing.
            float fl_rightx = Input.GetAxis("Right_Hor2");
            float fl_righty = Input.GetAxis("Right_Vert2");

            float fl_angler = Mathf.Atan2(fl_rightx, fl_righty);

            transform.rotation = Quaternion.EulerAngles(0, fl_angler, 0);

            if (transH == 0 && transV == 0)
            {
                transform.position = transform.position;

            }

        }



    }
    void PlayerSpeedUp()
    {
        fl_SpeedH = 20;
        fl_SpeedV = 20;
        if (Time.time > fl_time)
        {
            fl_time = Time.time + fl_duration;
            fl_SpeedH = 10;
            fl_SpeedV = 10;
        }
    }
    void PlayerSpeedDown()
    {
        fl_SpeedH = 5;
        fl_SpeedV = 5;
        if (Time.time > fl_time)
        {
            fl_time = Time.time + fl_duration;
            fl_SpeedH = 10;
            fl_SpeedV = 10;
        }
    }
}