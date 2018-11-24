using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pila : MonoBehaviour {
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Pila")
        {
            Destroy(gameObject);
        }
    }
}
