using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnVengalas : MonoBehaviour {

    public GameObject ItemAlCrear;
    public int Vengalas = 3;

    // Use this for initialization

	void Update ()
    {
        if (Input.GetButtonUp("Jump") && Vengalas >= 0)
        {
            Instantiate(ItemAlCrear, transform.position, transform.rotation);
            Vengalas -= 1;
        }
    }
}
