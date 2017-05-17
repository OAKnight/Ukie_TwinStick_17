using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM_Speed : MonoBehaviour {

    //variables

    public GameObject Player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider collider)
    {
        if (Player.CompareTag("Player1"))
        {
            Player.SendMessage("PlayerSpeedUp", enabled, SendMessageOptions.DontRequireReceiver);
        }
    }
}
