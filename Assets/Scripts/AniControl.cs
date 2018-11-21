using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//ani.SetBool("Caminando", true);
//ani.SetBool("Caminando", false);
//ani.SetBool("Idel", true);
//ani.SetBool("Idel", false);


public class AniControl : MonoBehaviour {

    Animator ani;

	// Use this for initialization
	void Start () {
        ani = GetComponent<Animator>();
	}

    public void Idel()
    {
        ani.SetBool("Idel", true);
        ani.SetBool("Caminando", false);
        ani.SetBool("Atacar", false);
        ani.SetBool("Muerte", false);
    }

    public void Caminando()
        {
            ani.SetBool("Idel", false);
            ani.SetBool("Caminando", true);
            ani.SetBool("Atacar", false);
            ani.SetBool("Muerte", false);
        }

    public void Atacar()
    {
        ani.SetBool("Idel", false);
        ani.SetBool("Caminando", false);
        ani.SetBool("Atacar", true);
        ani.SetBool("Muerte", false);
    }

    public void Muerte()
    {
        ani.SetBool("Idel", false);
        ani.SetBool("Caminando", false);
        ani.SetBool("Atacar", false);
        ani.SetBool("Muerte", true);
    }


}
