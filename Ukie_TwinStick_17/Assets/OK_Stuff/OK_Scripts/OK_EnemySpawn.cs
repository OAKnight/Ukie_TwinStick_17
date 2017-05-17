using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OK_EnemySpawn : MonoBehaviour {

    public float fl_speed;
    public float fl_time;
    private bool bl_load = true;

    public GameObject GO_Enemy;
    
    // Use this for initialization
	void Start () {
        fl_speed = fl_time;
	}
	
	// Update is called once per frame
	void Update () {
        SpawnNPC();
        SpTime();
	}
    void SpawnNPC()
    {
        if (bl_load == true)
        {
            Instantiate(GO_Enemy);
            bl_load = false;
        }

    }
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
