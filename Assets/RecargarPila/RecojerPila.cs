using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecojerPila : MonoBehaviour {

    public BarraDePila _BarraDePila;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _BarraDePila.TiempoRestante += _BarraDePila.TiempoMaximo - _BarraDePila.TiempoRestante;
            Destroy(gameObject);
            Debug.Log("Colicion");
            ApagarLinterna.CantidadPilas += 1;
        }
    }
}
