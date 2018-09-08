using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour {

    public Color color;
    public GameObject infoPanel;
    private bool isPlayerInside = false;
    public float rotationSpeed = 30f;
    private bool colorUpdated = false;

    private void Start()
    {
        infoPanel.SetActive(false);
    }

    private void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);
        if(Input.GetKeyDown(KeyCode.I) && isPlayerInside)
        {
            colorUpdated = !colorUpdated;
            gameObject.GetComponent<Renderer>().material.SetColor("_Color", colorUpdated? Color.green: Color.red);

            //gameObject.GetComponent<Renderer>().material.color = color;
            //gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
            
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            infoPanel.SetActive(true);
            isPlayerInside = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            infoPanel.SetActive(false);
            isPlayerInside = false;
        }
    }

}
