﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemigo")
        {
            Destroy(gameObject);
        }
    }
}
