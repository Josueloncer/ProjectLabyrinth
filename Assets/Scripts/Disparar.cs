using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour {

    public GameObject bala;
    public float delayTime = 8;
    public GameObject muzzleflash;
    private float delayMuzzle = .1f;
    private float delaySmoke = 1.9f;
    public AudioSource audioSource;
    public AudioSource audioSource2;
    public GameObject smoke;


    private float contador = 4;
	// Use this for initialization
	void Start ()
    {
        //audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKey(KeyCode.Mouse0) && contador > delayTime)
        {
            Instantiate(bala, transform.position, transform.rotation);
            Bala.numeroBalas += 1;
            contador = 0;
            muzzleflash.SetActive(true);
            smoke.SetActive(true);
            int random = Random.Range(1, 3);
            switch(random)
            {
                case 1:
                    {
                        audioSource.Play();
                        break;
                    }
                case 2:
                    {
                        audioSource2.Play();
                        break;
                    }
            }
        }


        if(contador > delayMuzzle)
        {
            muzzleflash.SetActive(false);
        }

        if(contador > delaySmoke)
        {
            smoke.SetActive(false);
        }


        contador += Time.deltaTime;
    }



}
