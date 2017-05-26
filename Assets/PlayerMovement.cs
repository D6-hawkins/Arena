using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public int Speed = 20;
    public float Gravity = 15.0f;
    private float x;
    private float y;
    private float z;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (gameObject.name == "Player1")
        {
            x = Input.GetAxis("Horizontal") * Time.deltaTime * Speed;
            z = Input.GetAxis("Vertical") * Time.deltaTime * Speed;
            y = Input.GetAxis("Jump") * Time.deltaTime * Gravity;
        }
        if (gameObject.name == "Player2")
        {
            x = Input.GetAxis("HorizontalP2") * Time.deltaTime * Speed;
            z = Input.GetAxis("VerticalP2") * Time.deltaTime * Speed;
            y = Input.GetAxis("JumpP2") * Time.deltaTime * Gravity;
        }
        if (gameObject.name == "Player3")
        {
            x = Input.GetAxis("HorizontalP3") * Time.deltaTime * Speed;
            z = Input.GetAxis("VerticalP3") * Time.deltaTime * Speed;
            y = Input.GetAxis("JumpP3") * Time.deltaTime * Gravity;
        }
        if (gameObject.name == "Player4")
        {
            x = Input.GetAxis("HorizontalP4") * Time.deltaTime * Speed;
            z = Input.GetAxis("VerticalP4") * Time.deltaTime * Speed;
            y = Input.GetAxis("JumpP4") * Time.deltaTime * Gravity;
        }
        if (x != 0 || y != 0 || z !=0)
        {
            transform.Translate(x, y, z);
        }

    }
}
