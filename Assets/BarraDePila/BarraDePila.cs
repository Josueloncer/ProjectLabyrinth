using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDePila : MonoBehaviour {

    Image Pila;
    public float TiempoMaximo = 60f;           //SEGUNDOS
    public float TiempoRestante;
    public GameObject luz;

	void Start ()
    {
        Pila = GetComponent<Image>();
        TiempoRestante = TiempoMaximo;
	}
	
	// Update is called once per frame
	void Update ()
    {
        //PONER ESTE PEDAZO CUANDO PRENDE LA LINTERNA
        if (TiempoRestante > 0)
        {
                TiempoRestante -= Time.deltaTime;
                Pila.fillAmount = TiempoRestante / TiempoMaximo;

        }
        if(TiempoRestante < 0)
        {
            luz.SetActive(false);
            ApagarLinterna.CantidadPilas = 0;
        }
        ////////////////////////////////////////////////////
	}
}
