using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarArma : MonoBehaviour
{
    public GameObject arma;
    public GameObject linterna;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            linterna.SetActive(true);
            arma.SetActive(false);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            arma.SetActive(true);
            linterna.SetActive(false);
        }

    }
}
