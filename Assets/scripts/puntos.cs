using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class puntos : MonoBehaviour {



	Text text;


	void Start () {
	

		text = GetComponent <Text> ();
	
	}
	
	void Update () {

	
		if (global.puntuacion < 0) 

			global.puntuacion = 0;

		text.text = "" + global.puntuacion;



	
	}


	public static void AddPoints ( int pointsToAdd) {


		global.puntuacion += pointsToAdd;

	}

	public static void RestartPoints() {

		global.puntuacion = 0;
	


	}


}