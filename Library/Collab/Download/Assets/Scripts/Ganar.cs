using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Ganar : MonoBehaviour
{
    public GameObject win;

    void OnCollisionEnter(Collision collision)
    {
            Debug.Log("Colisiono");

            win.SetActive(true);
    }
    
}
