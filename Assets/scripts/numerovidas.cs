using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class numerovidas : MonoBehaviour {



	Text text;


	void Start () {


		text = GetComponent <Text> ();

	}

	void Update () {


		if (global.vidas > 3) 

			global.vidas = 3;

		text.text = "" + global.vidas;




	}


	public static void restavida () {


		global.vidas = global.vidas - 1;


	}

	public static void establecevida () {


		global.vidas = 3;


	}



}
