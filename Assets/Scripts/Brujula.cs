using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Brujula : MonoBehaviour
{

    public Vector3 DireccionNorte;
    public Transform Jugador;
    public Quaternion Direccion;

    public RectTransform Aguja;//SPRITE DE LA AGUJA DE LA BRUJULA



    void Update()
    {
        voltiarNorte();
    }

    public void voltiarNorte()
    {
        DireccionNorte.z = Jugador.eulerAngles.y;
        Aguja.localEulerAngles = DireccionNorte;
    }
}
