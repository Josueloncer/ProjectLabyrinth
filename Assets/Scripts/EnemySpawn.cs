using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    public GameObject Enemigo;
    public int EnemigosMaximas = 4;
    [Space(15)]
    int CrearNuevaEnemigo;
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
    public Transform Pos11;
    public Transform Pos12;
    public Transform Pos13;
    public Transform Pos14;
    public Transform Pos15;
    
    [Header("Dejalo en 0")]
    public int TotalDeEnemigos;

    void Start()
    {
        //PONER UN TAG DE    "Enemigo"     AL PREFAB DE Enemigo 
        TotalDeEnemigos = GameObject.FindGameObjectsWithTag("Enemigo").Length;  //REVISA CUANTAS EnemigoS HAY EN LA ESCENA

        if (TotalDeEnemigos < 4)
        {
            LugarDeEnemigo();                                                  //AL INICIO DEL JUEGO CREA 2 EnemigoS
        }
    }

    void Update()
    {
        TotalDeEnemigos = GameObject.FindGameObjectsWithTag("Enemigo").Length;  //REVISA CUANTAS EnemigoS HAY EN LA ESCENA

        if (TotalDeEnemigos < EnemigosMaximas)
        {
            LugarDeEnemigo();                                                  //SI HAY MENOS DE 2 EnemigoS 
        }

    }

    public void LugarDeEnemigo()
    {
        CrearNuevaEnemigo = Random.Range(1, 11);

        switch (CrearNuevaEnemigo)
        {
            case 1:
                Instantiate(Enemigo, Pos1.position, Pos1.rotation);
                break;
            case 2:
                Instantiate(Enemigo, Pos2.position, Pos2.rotation);
                break;
            case 3:
                Instantiate(Enemigo, Pos3.position, Pos3.rotation);
                break;
            case 4:
                Instantiate(Enemigo, Pos4.position, Pos4.rotation);
                break;
            case 5:
                Instantiate(Enemigo, Pos5.position, Pos5.rotation);
                break;
            case 6:
                Instantiate(Enemigo, Pos6.position, Pos6.rotation);
                break;
            case 7:
                Instantiate(Enemigo, Pos7.position, Pos7.rotation);
                break;
            case 8:
                Instantiate(Enemigo, Pos8.position, Pos8.rotation);
                break;
            case 9:
                Instantiate(Enemigo, Pos9.position, Pos9.rotation);
                break;
            case 10:
                Instantiate(Enemigo, Pos10.position, Pos10.rotation);
                break;
            case 11:
                Instantiate(Enemigo, Pos6.position, Pos11.rotation);
                break;
            case 12:
                Instantiate(Enemigo, Pos7.position, Pos12.rotation);
                break;
            case 13:
                Instantiate(Enemigo, Pos8.position, Pos13.rotation);
                break;
            case 14:
                Instantiate(Enemigo, Pos9.position, Pos14.rotation);
                break;
            case 15:
                Instantiate(Enemigo, Pos10.position, Pos15.rotation);
                break;


            default:
                Debug.Log("Not Working");
                break;

        }
    }

}
