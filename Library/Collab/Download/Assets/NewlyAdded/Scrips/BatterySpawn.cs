using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatterySpawn : MonoBehaviour {

    [SerializeField]
    [TextArea(8, 9)]
    private string QueHacer = "Cuando arrastras el prefab de *Ecenario* a la escena haba 10 esferas, cada una de ellas ponlos en el espacio que dice *Pos 1, 2, 3 etc.*\nSon los lugares donde Spawnearan las pilas. Despues se puede desactivar el *Mesh Renderer* de las esferas.\nEn el aparrtado que dice pilla arrastrar el prefab de pila";


    public GameObject Pila;
    public int PilasMaximas = 2;
    [Space(15)]
    int CrearNuevaPila;
    public Transform Pos1;
    public Transform Pos2;
    public Transform Pos3;
    public Transform Pos4;
    public Transform Pos5;
    public Transform Pos6;
    public Transform Pos7;
    public Transform Pos8;
    public Transform Pos9;
    public Transform Pos10;
    [Header("Dejalo en 0")]
    public int TotalDePilas;

    void Start()
    {
        //PONER UN TAG DE    "Pila"     AL PREFAB DE PILA 
        TotalDePilas = GameObject.FindGameObjectsWithTag("Pila").Length;  //REVISA CUANTAS PILAS HAY EN LA ESCENA

        if (TotalDePilas < 2)
        {
            LugarDePila();                                                  //AL INICIO DEL JUEGO CREA 2 PILAS
        }
    }

    void Update ()
    {
        TotalDePilas = GameObject.FindGameObjectsWithTag("Pila").Length;  //REVISA CUANTAS PILAS HAY EN LA ESCENA

        if (TotalDePilas < PilasMaximas)
        {
            LugarDePila();                                                  //SI HAY MENOS DE 2 PILAS 
        }

    }

    public void LugarDePila()
    {
        CrearNuevaPila = Random.Range(1, 11);

        switch (CrearNuevaPila)
        {
            case 1:
                Instantiate(Pila, Pos1.position, Pos1.rotation);
                break;
            case 2:
                Instantiate(Pila, Pos2.position, Pos2.rotation);
                break;
            case 3:
                Instantiate(Pila, Pos3.position, Pos3.rotation);
                break;
            case 4:
                Instantiate(Pila, Pos4.position, Pos4.rotation);
                break;
            case 5:
                Instantiate(Pila, Pos5.position, Pos5.rotation);
                break;
            case 6:
                Instantiate(Pila, Pos6.position, Pos6.rotation);
                break;
            case 7:
                Instantiate(Pila, Pos7.position, Pos7.rotation);
                break;
            case 8:
                Instantiate(Pila, Pos8.position, Pos8.rotation);
                break;
            case 9:
                Instantiate(Pila, Pos9.position, Pos9.rotation);
                break;
            case 10:
                Instantiate(Pila, Pos10.position, Pos10.rotation);
                break;
            default:
                Debug.Log("Not Working");
                break;

        }
    }

}
