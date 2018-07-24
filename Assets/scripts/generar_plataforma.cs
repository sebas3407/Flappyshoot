using UnityEngine;
using System.Collections;

public class generar_plataforma : MonoBehaviour {
	public GameObject plataforma;
	// Use this for initialization
	void Start () {
		InvokeRepeating("CreateObject",1,5);
	}
	
	// Update is called once per frame
	void Update () {
	}
	void CreateObject()
	{
		Instantiate(plataforma);
		
	}
}
