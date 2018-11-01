using UnityEngine;

public class Bala : MonoBehaviour {

	public float speed = 1f;
	public float tiempoDestruir = 0;
	public static int numeroBalas;
	public Transform splash;

	void OnCollisionEnter(Collision col) {
		/*
            ContactPoint[] contact = col.contacts;
            Vector3 startPos = contact[0].point;
            Quaternion startRot = Quaternion.LookRotation(contact[0].normal);
            Instantiate(splash, startPos, startRot);
        */
		Debug.Log("Collision");
	}

	// Use this for initialization
	void Start() {

	}

	// Update is called once per frame
	void Update() {
		transform.Translate(0, 0, speed);
		tiempoDestruir += Time.deltaTime;

		if (tiempoDestruir >= 2) {
			numeroBalas -= 1;
			Destroy(GameObject.FindWithTag("Bala"));
			if (numeroBalas == 0) {
				tiempoDestruir = 0;
			}
		}
	}
}