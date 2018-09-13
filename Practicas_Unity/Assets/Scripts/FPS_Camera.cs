using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS_Camera : MonoBehaviour {

    public Camera FPSCamera;
    public float deltaRotate;
    public float deltaMovement;    

	// Use this for initialization
	void Start () {
        deltaRotate = 80f;
	    deltaMovement = 5f;
	}
	
	// Update is called once per frame
	void Update () {
        Rotate();
	    Movement();
	}

    void Rotate()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0f, deltaRotate, 0f) * Time.deltaTime);
        }
        else
        {
            if(Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(new Vector3(0f, -deltaRotate, 0f) * Time.deltaTime);
            }
        }
    }

    void Movement()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0f, 0f, deltaMovement) * Time.deltaTime);
        }
        else
        {
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(new Vector3(0f, 0f, -deltaMovement) * Time.deltaTime);
            }
        }
    }
}
