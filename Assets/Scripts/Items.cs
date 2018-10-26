using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Items : MonoBehaviour
{
    public Text texto;

    void OnTriggerEnter()
    {
        Debug.Log("Colsiona");
        VariablesGlobales.valor = VariablesGlobales.valor + 1;
        texto.text = VariablesGlobales.valor.ToString();
        Destroy(this);
        Destroy(gameObject);
    }
}
