using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuerteEnemigo : MonoBehaviour {
    
    Animator ani;
    CapsuleCollider cap;
    BoxCollider cube;

    // Use this for initialization
    void Start () {
        
        ani = GetComponent<Animator>();
        cap = GetComponent<CapsuleCollider>();
        cube = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bala")
        {
            //Debug.Log("HEAD HIT");
            Muerte();
        }
        
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
        cap.enabled = false;
        cube.enabled = true;
    }

}
