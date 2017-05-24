using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChanger : MonoBehaviour {
    float Colour = 0.0f;
    float PrevColour = 0.0f;
	// Use this for initialization
	void Start () {
       // print("Colour started");
        GetComponent<Renderer>().material.color = new Color(Colour, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if (Colour != PrevColour)
        {
           // print(Colour);
            GetComponent<Renderer>().material.color = new Color(Colour, 0, 0);
            PrevColour = Colour;
        }
	}
    void OnTriggerStay(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            Colour += 0.01f;
            print(Colour);
        }
        if (Colour > 1.5f)
        {
            Destroy(gameObject);
        }
    }
}
