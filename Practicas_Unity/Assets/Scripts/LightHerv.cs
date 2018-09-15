using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightHerv : MonoBehaviour {

    public GameObject luz;
	// Use this for initialization
	void Start () {
        //light = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            luz.SetActive(true);
            //light.enabled = true;
            print("Adentro");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            luz.SetActive(false);
            //light.enabled = false;
            print("Afuera");
        }
    }
}
