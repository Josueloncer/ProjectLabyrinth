using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBattery : MonoBehaviour {

	public GameObject Pila;
	GameObject PilaVieja;
	GameObject PilaNueva;
	int PosicionDeNuevaPila;
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

	void Update()
	{
		if (Input.GetKeyDown("space"))
		{
			NuevaPila();
		}
	}

	public void NuevaPila()
	{
		if (GameObject.Find("Pila1") != null)
		{
			NuevaPila1();
		}

		if (GameObject.Find("Pila2") != null)
		{
			//NuevaPila2();
		}

	}

	public void NuevaPila1()
	{
		switch (PosicionDeNuevaPila)
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
