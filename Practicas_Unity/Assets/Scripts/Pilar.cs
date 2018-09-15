using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pilar : MonoBehaviour {

    public float deltaMovement;
    private bool isPlayerInside = false;
    private float cantidad=20;
    public GameObject muro1;
    private float desplazamientoY;
    public AudioClip firsStone;
    public AudioClip secondStone;

    AudioSource fuenteAudio;

    // Use this for initialization
    void Start () {
        deltaMovement = 1f;
        desplazamientoY = 200f;
        fuenteAudio = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        MoveStone();
        if (cantidad == 0)
        {
            OpenSecreteDoor();
        }
    }

    private void MoveStone()
    {
        if (Input.GetKey(KeyCode.A) && isPlayerInside && cantidad > 0)
        {
            transform.Translate(new Vector3(0f, 0f, -deltaMovement) * Time.deltaTime);
            cantidad--;
            print("Presionaste A");
//            fuenteAudio.clip = firsStone;
 //           fuenteAudio.Play();
        }
        if(cantidad<=0)
        {
            fuenteAudio.clip = secondStone;
            fuenteAudio.Play();
        }

    }

    private void OpenSecreteDoor()
    {

        if (desplazamientoY > 0)
        {
            muro1.transform.Translate(new Vector3(0f, deltaMovement, 0f) * Time.deltaTime);
            desplazamientoY--;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInside = true;
            print("inside");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInside = false;
            print("outside");
        }
    }

}
