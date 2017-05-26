using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillSwitch : MonoBehaviour {
    // Use this for initialization
    //public GameObject player1;
	void Start () {
        print("start");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            print(Player.name);
            print("Is dead.");
            Destroy(Player.gameObject);
        }
    }
}
