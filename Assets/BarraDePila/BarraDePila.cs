using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDePila : MonoBehaviour {

    Image Pila;
    public float TiempoMaximo = 30f;           //SEGUNDOS
    public static float TiempoRestante;
    public GameObject luz;
    public Sprite sprite1,sprite2,sprite3,sprite4,sprite5,sprite6;
    Image m_Image;
    public GameObject linternaActivada;

    void Start ()
    {
        Pila = GetComponent<Image>();
        TiempoRestante = TiempoMaximo;
        m_Image = GetComponent<Image>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(linternaActivada.activeInHierarchy == true)
        {
            if (TiempoRestante > 0)
            {
                TiempoRestante -= Time.deltaTime;
                //Pila.fillAmount = TiempoRestante / TiempoMaximo;

            }
        }

        if (TiempoRestante <= 30)
        {
            m_Image.sprite = sprite6;
        }


        if (TiempoRestante <= 25)
        {
            m_Image.sprite = sprite5;
        }

        if (TiempoRestante <= 20)
        {
            m_Image.sprite = sprite4;
        }


        if (TiempoRestante <= 15)
        {
            m_Image.sprite = sprite3;
        }


        if (TiempoRestante <= 10)
        {
            m_Image.sprite = sprite2;
        }

        if (TiempoRestante <= 0)
        {
            m_Image.sprite = sprite1;
        }


        if (TiempoRestante < 0)
        {
            luz.SetActive(false);
            ApagarLinterna.CantidadPilas = 0;
        }
        ////////////////////////////////////////////////////
	}
}
