using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {

    CharacterController charControl;
    public float velocidad;
    public Animation anim;
    private bool left;
    private bool right;
    public AudioSource audioSource;
    public bool sonido = false;


    // Use this for initialization


    void Start()
    {
        left = true;
        right = false;
    }



    void Awake () {
        charControl = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {

        MovePlayer();

    }

    void MovePlayer()
    {
        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

        Vector3 moveDirSide = transform.right * horiz * velocidad;
        Vector3 moveDirForward = transform.forward * vert * velocidad;

        charControl.SimpleMove(moveDirSide);
        charControl.SimpleMove(moveDirForward);


        if (Input.GetKeyDown("w"))
        {
            sonido = false;
        }
        if (Input.GetKeyUp("w"))
        {
            sonido = true;
        }

        if (Input.GetKeyDown("a"))
        {
            sonido = false;
        }
        if (Input.GetKeyUp("a"))
        {
            sonido = true;
        }

        if (Input.GetKeyDown("s"))
        {
            sonido = false;
        }
        if (Input.GetKeyUp("s"))
        {
            sonido = true;
        }

        if (Input.GetKeyDown("d"))
        {
            sonido = false;
        }
        if (Input.GetKeyUp("d"))
        {
            sonido = true;
        }


        if (sonido == true)
        {
            audioSource.Play();
        }
        


        if (horiz < 0)
        {
            //left = true;
            //right = false;

            anim.Play("Movimiento_izquierdo");
            
            // Debug.Log("Izquierda");

        }

        if (horiz > 0)
        {
            //left = true;
            //right = false;

            anim.Play("Movimiento_Derecho");
            
            //Debug.Log("Derecha");

        }

        if (vert > 0)
        {
            //left = false;
            //right = true;

                anim.Play("Movimiento_Derecho");
           
            // Debug.Log("Adelante");

        }

        if (vert < 0)
        {
            //left = false;
            //right = true;

            anim.Play("Movimiento_izquierdo");
            
            //Debug.Log("Atras");

        }

        if (horiz == 0 && vert == 0)
        {
            anim.Play("Movimiento_Idle");
        }



    }
}
