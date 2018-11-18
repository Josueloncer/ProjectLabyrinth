using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApagarLinterna : MonoBehaviour {

    public GameObject luz;
    public float contador;
    public static float CantidadPilas = 1;

	// Use this for initialization
	void Start ()
    {
		
	}

    // Update is called once per frame
    void Update()
    { 
        if(contador > 50)
        {
            contador = 0;
        }

        contador++;
        
        if (luz.activeInHierarchy)
        {
           if(contador >= 8)
            {

                    if (Input.GetKey(KeyCode.F))
                    {
                        luz.SetActive(false);
                        contador = 0;
                    }
            }
        }
        else
        {
            if (contador >= 8)
            {
                if (CantidadPilas >= 1)
                {
                    if (Input.GetKey(KeyCode.F))
                    {
                        luz.SetActive(true);
                        contador = 0;
                    }
                }
            }
        }

	}
}
