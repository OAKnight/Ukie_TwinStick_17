using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OK_CameraControls : MonoBehaviour {

    public GameObject GO_PC;
    public float fl_angle;
    public float fl_height;



	// Use this for initialization
	void Start () {




	}
	
	// Update is called once per frame
    void LateUpdate()
    {

        CameraMove();

    }

    void CameraMove()
    {
        transform.position = GO_PC.transform.position;
        transform.position -= Vector3.forward * fl_angle;
        transform.position = new Vector3(transform.position.x, fl_height, transform.position.z);
        transform.LookAt(GO_PC.transform.position);

    }
}
