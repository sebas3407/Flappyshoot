using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tiempo : MonoBehaviour {


	Text text;


	void Start () {

		global.tiemporestante = 20;
		text = GetComponent <Text> ();
	}

	void Update () {



		global.tiemporestante -= Time.deltaTime;
		text.text = "" + global.tiemporestante.ToString("f0");

		if (global.tiemporestante.ToString("f0") =="0") {


			if (global.nivel == 1) {


				global.nivel = 2;
				SceneManager.LoadScene ("juego2");

			} else if (global.nivel == 2) {
				global.nivel = 3;
				SceneManager.LoadScene ("juego3");

			}


		

		}

	}



}
