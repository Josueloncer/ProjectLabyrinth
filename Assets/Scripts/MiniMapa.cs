using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapa : MonoBehaviour
{

    public Transform Jugador;

    void LateUpdate()
    {
        Vector3 nuevaPoscicion = Jugador.position;
        nuevaPoscicion.y = transform.position.y;
        transform.position = nuevaPoscicion;
    }

}
