using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimatioinControler : MonoBehaviour
{
    [SerializeField]
    [TextArea(19, 20)]
    private string QueHacer = "Hacer un nuevo Tag LLamado *Enemigo* y Ponerselo al Enemigo.\n En los espacios de abajo donde dice Balas, Mapa, Jugador se pondra:\n En Balas: El Prefab de las balas que el enemigo tirara al morir.\n En Mapa: SE SUPONE QUE DEBE DE IR EL PREFAB DEL MAPA QUE EL ENEMIGO TIRARA AL MORIR SI ES EL ULTIMO, PERO POR ALGUNA RAZON ESO AUN NO SIRVE.\n En Jugador: Va el Jugador.\n El Enemigo esta cubierto de HITBOXES (SON LO QUE SE VE VERDE) para que tome deano.\n Selecciona todos los Hitboxes ***MENOS EL DE LA CABEZA*** y Ahregales un Tag de *Cuerpo*\n La cabeza agregale un Tag de *Cabeza*\n Por Ultimo se desactiva el *Mesh Renderer* de TODOS los Hitboxes para que no se vea";


    public int HP = 2;
    [Space(15)]
    public RuntimeAnimatorController ControladorCaminar;
	public RuntimeAnimatorController ControladorAtaque;
	public RuntimeAnimatorController ControladorMuerte;
    [Space(15)]
    [Header("Distancia Minima Para Que Ataque")]
    public float DistanciaMinParaAtacar = 0.25f;
    [Space(15)]
    [Header("Balas Que se Espawnean")]
    public GameObject Balas;
    public GameObject Mapa;
    public GameObject Jugador;
    float DistanciaDeJugador; //REVISAR LA DISTANCIA MINIMA QUE EL JUGADOR NECESITA ESTAR PARA QUE ATAKE EN ESTE CASO ES 2.5
    public int NumeroDeEnemigos;
    BoxCollider ColicionEnemiga;
    CapsuleCollider TriggerEnemiga;

    void Start()
	{
		this.GetComponent<Animator>().runtimeAnimatorController = ControladorCaminar as RuntimeAnimatorController;							//EMPIEZA CON LA ANIMACIO DE
        ColicionEnemiga = this.GetComponent<BoxCollider>();
        TriggerEnemiga = this.GetComponent<CapsuleCollider>();
    }

	void Update()
	{
        //PONER UN TAG DE    "Enemigo"     AL PREFAB DE Enemigo
        NumeroDeEnemigos = GameObject.FindGameObjectsWithTag("Enemigo").Length;  //REVISA CUANTAS PILAS HAY EN LA ESCENA

        DistanciaDeJugador = Vector3.Distance(Jugador.transform.position, transform.position);

		//
		if (DistanciaDeJugador <= 2.5 && this.GetComponent<Animator>().runtimeAnimatorController != ControladorMuerte as RuntimeAnimatorController)
		{
			this.GetComponent<Animator>().runtimeAnimatorController = ControladorAtaque as RuntimeAnimatorController;					//ANIMACION DE ATACAR SI EL JUGADOR ESTTA CERCA
		}
        if (DistanciaDeJugador > 2.5 && this.GetComponent<Animator>().runtimeAnimatorController != ControladorMuerte as RuntimeAnimatorController)
        {
            this.GetComponent<Animator>().runtimeAnimatorController = ControladorCaminar as RuntimeAnimatorController;
		}
		//

		//
		if (Input.GetKeyDown("space"))
		{
			HP -= 1;																											//TOMA DAÑO
		}
		//

		//
		if (HP == 0 && this.GetComponent<Animator>().runtimeAnimatorController != ControladorMuerte as RuntimeAnimatorController)		
		{
            //this.tag = "Untagged";                                                                                              //ELIMINA EL TAG DEL ENEMIGO SIMULA QUE YA NO ESTA EN EL NIVEL
            Death();                                                                                                            //SI SU VIDA BAJA A 0 ANIMACION SERA DE MUERTE
        }
        //
        
        //
    }

	void Death()
	{
        TriggerEnemiga.enabled = false;                                                                                    //DESACTIVA CAPSULA DE TRIGGER CUANDO SE MUERE
        ColicionEnemiga.enabled = false;                                                                                    //DESACTIVA CAJA DE COLICION CUANDO SE MUERE
        this.GetComponent<Animator>().runtimeAnimatorController = ControladorMuerte as RuntimeAnimatorController;
        Instantiate(Balas, transform.position + (transform.up * .5f), transform.rotation);                                  //CREA BALAS ENFRENTE DE DONDE SE MURIO
        /*if(NumeroDeEnemigos > 0)
        {
            TriggerEnemiga.enabled = false;                                                                                    //DESACTIVA CAPSULA DE TRIGGER CUANDO SE MUERE
            ColicionEnemiga.enabled = false;                                                                                    //DESACTIVA CAJA DE COLICION CUANDO SE MUERE
            this.GetComponent<Animator>().runtimeAnimatorController = ControladorMuerte as RuntimeAnimatorController;
            Instantiate(Balas, transform.position + (transform.up * .5f), transform.rotation);                                  //CREA BALAS ENFRENTE DE DONDE SE MURIO
        }*/

        //  NO FUNCIONA
        if (NumeroDeEnemigos < 0)
        {
            this.GetComponent<Animator>().runtimeAnimatorController = ControladorMuerte as RuntimeAnimatorController;
            Instantiate(Mapa, transform.position + (transform.up * .5f), transform.rotation);                                  //CREA MAPA ENFRENTE DE DONDE SE MURIO
        }
        //
    }
}
