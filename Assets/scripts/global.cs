﻿using UnityEngine;
using System.Collections;

public class global : MonoBehaviour {

	public GUIStyle Score;
	public GUIStyle Contador;
	public GUIStyle Lives;

	public static float tiemporestante;
	public static int puntuacion = 0;
	public static int vidas = 3;
	public static int nivel = 1;


	void Start () {
	
	}
	
	// Update is called once per frame

	void Update () {
	}

	void OnGUI() {
		

		GUI.color = Color.white;
		GUILayout.Label ("Score: " + puntuacion.ToString (), Score);
		GUILayout.Label (tiemporestante.ToString (), Contador);

	             
		                
		                }

}
