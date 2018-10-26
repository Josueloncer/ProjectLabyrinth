using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerrarMapa : MonoBehaviour {

    public float contador;
    public GameObject mapa;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        contador++;

        if (contador > 50)
        {
            contador = 0;
        }

        if (mapa.activeInHierarchy)
        {
            if (contador >= 8)
            {
                if (Input.GetKey(KeyCode.G))
                {
                    mapa.SetActive(false);
                    contador = 0;
                }
            }
        }

        else
        {
            if (contador >= 8)
            {
                if (Input.GetKey(KeyCode.G))
                {
                    mapa.SetActive(true);
                    contador = 0;
                }
            }
        }
    }
}
