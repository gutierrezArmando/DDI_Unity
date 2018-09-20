using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableBaseBattery : MonoBehaviour
{

	private bool batteryOk;
	private bool intoSphere;
	public GameObject inventoryPanel;
	public GameObject lightBattery;
	public AudioSource motorSound;
	public GameObject closedDoor;
	private int repeat = 220;
	public GameObject battery;
	// Use this for initialization
	void Start ()
	{
		batteryOk = false;
		intoSphere = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space) && intoSphere && !batteryOk)
		{
			if (inventoryPanel.transform.Find("Battery").gameObject.activeSelf)
			{
				inventoryPanel.SetActive(true);
				//putBattery();
			}
			else
			{
				print("No esta en inventario");
			}
		}
		
		if(batteryOk)
			OpenDoor();
		//putBattery();
	}

	private void OnTriggerEnter(Collider other)
	{
		intoSphere = true;
	}

	private void OnTriggerExit(Collider other)
	{
		intoSphere = false;
	}

	public void putBattery()
	{
		print("Entro al metodo");
		if (!batteryOk && intoSphere)
		{
			battery.SetActive(true);
			battery.transform.position = new Vector3(53.57f, 2.6f, -6.74f);
			battery.transform.Rotate(-151.886f, 0f, 0f);
			batteryOk = true;
			inventoryPanel.transform.Find("Battery").gameObject.SetActive(false);
			inventoryPanel.SetActive(false);
			lightBattery.SetActive(true);
			motorSound.mute = false;
			//OpenDoor();
			print("Bateria colocada");
		}
	}

	private void OpenDoor()
	{
		if (repeat>0)
		{
			closedDoor.transform.Translate(new Vector3(0f, 1f, 0f) * Time.deltaTime);
			repeat--;
		}

	}
}
