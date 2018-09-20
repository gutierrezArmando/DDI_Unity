using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableBigBattery : MonoBehaviour
{
	public AudioSource motorSound;
	public GameObject lightMainBattery;

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	private void OnTriggerEnter(Collider other)
	{
		//if(lightMainBattery.activeSelf)
		//	motorSound.mute = false;
	}

	private void OnTriggerExit(Collider other)
	{
		//motorSound.mute = true;
	}

}
