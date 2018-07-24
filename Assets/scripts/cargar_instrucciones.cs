using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class cargar_instrucciones : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void CargarInstrucciones() {


		SceneManager.LoadScene ("instrucciones");
	}
}
