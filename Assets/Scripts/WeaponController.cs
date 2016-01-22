using UnityEngine;
using System.Collections;

public class WeaponController : MonoBehaviour {

	public float speed;
	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	public float delay;

	private AudioSource audio;

	void Start() {
		audio = GetComponent<AudioSource> ();
		InvokeRepeating ("Fire", delay, fireRate);
	}

	void Fire() {
		Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
		audio.Play ();
	}
}
