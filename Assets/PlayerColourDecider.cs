using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColourDecider : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (gameObject.name == "Player1")
        {
            GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 1); //Make 'em Red
            GetComponent<TrailRenderer>().material.color = new Color(0, 0, 0);
        }
        if (gameObject.name == "Player2")
        {
            GetComponent<Renderer>().material.color = new Color(0, 255, 0); //Make 'em Green
            GetComponent<TrailRenderer>().material.color = new Color(0, 255, 0);
        }
        if (gameObject.name == "Player3")
        {
            GetComponent<Renderer>().material.color = new Color(0, 0, 255); //Make 'em Blue
            GetComponent<TrailRenderer>().material.color = new Color(0, 0, 255);
        }
        if (gameObject.name == "Player4")
        {
            GetComponent<Renderer>().material.color = new Color(0, 255, 255); //Make 'em Turqiouse
            GetComponent<TrailRenderer>().material.color = new Color(0, 255, 255);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
