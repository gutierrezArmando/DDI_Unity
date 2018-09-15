using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LamparaSensitiva : MonoBehaviour {

    public GameObject luz;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            luz.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            luz.SetActive(false);
        }
    }
}
