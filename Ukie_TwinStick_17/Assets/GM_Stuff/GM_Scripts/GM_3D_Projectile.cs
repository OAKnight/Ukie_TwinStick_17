using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM_3D_Projectile : MonoBehaviour {

	// ----------------------------------------------------------------------
    // Variables

    public float fl_range = 5;
    public float fl_speed = 10;
    public float fl_damage = 10;
    public float fl_next_fire = 0.5f;
    private float fl_fire_rate = 0.0f;
    private bool bl_arrow_hit;
    private Rigidbody RB_arrow;

    // ----------------------------------------------------------------------
    // Use this for initialization
    void Start () {
        Destroy(gameObject, fl_range / fl_speed);
        RB_arrow = GetComponent<Rigidbody>();
        RB_arrow.velocity =  fl_speed * transform.TransformDirection(Vector3.forward);
    } //-----	

    // ----------------------------------------------------------------------
    // Update is called once per frame
    void Update () {
        

    } //-----


    void OnCollisionEnter(Collision _col_arrow_hit)
    {
        _col_arrow_hit.collider.gameObject.SendMessage("Damage", fl_damage, SendMessageOptions.DontRequireReceiver);
        Destroy(gameObject);
    }

    void ProjectileSpeed()
    {
        fl_speed = 25;
        if (Time.time > fl_next_fire) //if enough time elapsed
        {
            fl_next_fire = Time.time + fl_fire_rate;
            fl_speed = 10;
        }
    }

}//==========

