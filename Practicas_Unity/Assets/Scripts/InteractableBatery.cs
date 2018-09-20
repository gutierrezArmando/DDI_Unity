using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableBatery : MonoBehaviour
{
	private bool intoSphere;//Para iindicar cuando el personaje esta haciendo colision
	private bool bateryActive;//
	public GameObject questionPanel;//Para mostrar u ocultar el panel que contiene el mensaje
	public GameObject inventoryPanel;
	private bool onInvetory;
	private bool panelOpened;
	
	// Use this for initialization
	void Start ()
	{
		intoSphere = false;
		bateryActive = false;
		onInvetory = false;
		panelOpened = false;
	}
	
	// Update is called once per frame
	void Update () {
		question();
		if (panelOpened)
		{
			if (Input.GetKeyUp(KeyCode.N))
			{
				panelOpened = false;
				questionPanel.SetActive(false);
				print("Panel de pregunta cerrado");
			}

			if (Input.GetKeyDown(KeyCode.Y))
			{
				takeBattery();
				panelOpened = false;
				questionPanel.SetActive(false);
			}
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		intoSphere = true;
//		float i = gameObject.GetComponent<Renderer>().transform.position.y;
	}

	private void OnTriggerExit(Collider other)
	{
		intoSphere = false;
	}

	private void takeBattery()
	{
		gameObject.SetActive(false);
		onInvetory = true;
//		inventoryPanel.SetActive(true);
		inventoryPanel.transform.Find("Battery").gameObject.SetActive(true);
		print("BATERIA AGREGADA AL INVENTARIO");
	}

	private void question()
	{
		if (intoSphere && Input.GetKeyUp(KeyCode.Space)&& !onInvetory)
		{
			questionPanel.SetActive(true);
			panelOpened = true;
			print("Panel de pregunta abierto");
		}
	}
	
}
