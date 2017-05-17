using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM_Fire_Rate : MonoBehaviour {

    //Variables
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
            Player.SendMessage("FireRate", enabled, SendMessageOptions.DontRequireReceiver);
        }
    }
}
