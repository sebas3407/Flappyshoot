using UnityEngine;
using System.Collections;

public class generarenemigos : MonoBehaviour {

	public GameObject enemigo;
	public Transform posicionregeneramiento;
	public float tiemporegeneramiento = 3f;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("regenerar",tiemporegeneramiento, tiemporegeneramiento);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

 void regenerar() {

		Instantiate (enemigo, posicionregeneramiento.position, posicionregeneramiento.rotation);

	}

}
