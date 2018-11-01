using UnityEngine;

public class Disparar : MonoBehaviour {
	public GameObject bala;
	public float delayTime = 8;
	public GameObject muzzleflash;
	private float delayMuzzle = .1f;
	private float delaySmoke = 1.9f;
	public AudioClip[] ShootSounds;
	public AudioSource audioSource;
	public GameObject smoke;

	private float contador = 4;

	// Update is called once per frame
	void Update() {
		if (Input.GetKey(KeyCode.Mouse0) && contador > delayTime) {
			Instantiate(bala, transform.position, transform.rotation);
			Bala.numeroBalas += 1;
			contador = 0;
			muzzleflash.SetActive(true);
			smoke.SetActive(true);
			int random = Random.Range(0, ShootSounds.Length);
			audioSource.PlayOneShot(ShootSounds[random]);
			//Debug.Break();
		}

		if (contador > delayMuzzle) {
			muzzleflash.SetActive(false);
		}

		if (contador > delaySmoke) {
			smoke.SetActive(false);
		}

		contador += Time.deltaTime;
	}
}