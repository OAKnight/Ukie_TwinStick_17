// ----------------------------------------------------------------------
// -------------------- 3D Projectile
// -------------------- David Dorrington, UEL Games, 2016
// ----------------------------------------------------------------------
using UnityEngine;
using System.Collections;


[RequireComponent(typeof(Rigidbody))]
public class DD_3D_Projectile : MonoBehaviour {

    // ----------------------------------------------------------------------
    // Variables

    public float fl_range = 5;
    public float fl_speed = 10;
    public float fl_damage = 10;
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

}//==========
