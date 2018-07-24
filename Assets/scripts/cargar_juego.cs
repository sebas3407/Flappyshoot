using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class cargar_juego : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void cargarJuego() {
		global.nivel = 1;
		puntos.RestartPoints ();
		numerovidas.establecevida ();
		SceneManager.LoadScene ("juego");


	}
}
