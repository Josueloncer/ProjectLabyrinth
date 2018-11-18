using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour {

    public float speed = 1f;
    public float tiempoDestruir = 0;
    public static int numeroBalas;
    public Transform splash;


        /*
            ContactPoint[] contact = col.contacts;
            Vector3 startPos = contact[0].point;
            Quaternion startRot = Quaternion.LookRotation(contact[0].normal);
            Instantiate(splash, startPos, startRot);
        */

    void Start ()
    {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.LogFormat("{0} chocó con {1}", gameObject.name, other.gameObject.name);

        // TODO Aquí se puede poner el código para mostrar la marca del disparo sobre la pared.

        Destroy(gameObject); // TODO Aquí se destruye el objeto, pero lo mejor sería guardarlo en un pool para reutilizarlo.
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed);
    }

    // Update is called once per frame




}
