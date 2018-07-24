
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class nave : MonoBehaviour {
	public Vector2 jump  = new Vector2(0,1000);
	public Vector2 adelante  = new Vector2(600,0);
	public Vector2 atras  = new Vector2(-600,0);
	public Image barra;
	public Transform puntobala;
	public GameObject bala;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("space")) {


			GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			GetComponent<Rigidbody2D>().AddForce(jump);


		}
		if (Input.GetAxis("Horizontal")>0) {


			GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			GetComponent<Rigidbody2D>().AddForce(adelante);

			transform.rotation = Quaternion.Euler(0,0,0);

		}
		else if (Input.GetAxis("Horizontal")<0){


			GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			GetComponent<Rigidbody2D>().AddForce(atras);
			transform.rotation = Quaternion.Euler(0,180,0);


		}

		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			GetComponent<Rigidbody2D>().AddForce(-jump);

			transform.rotation = Quaternion.Euler(0,0,0);
		}

		if (Input.GetKeyDown (KeyCode.RightControl)) {
			transform.rotation = Quaternion.Euler(0,0,0);
			Instantiate (bala, puntobala.position, puntobala.rotation);
		}
		
		if (Input.GetKeyDown (KeyCode.LeftControl)) {
			transform.rotation = Quaternion.Euler(0,0,0);
			Instantiate (bala, puntobala.position, puntobala.rotation);
		}

		Vector2 posicion ;
		posicion = Camera.main.WorldToScreenPoint(transform.position);


		if (posicion.y > Screen.height || posicion.y < 0 ) {
			Morir();
		}

		if (posicion.x > Screen.width|| posicion.x < 0 ) {
			Morir();
		}



	
	}

	void OnCollisionEnter2D(Collision2D other) {

		if (other.gameObject.tag == "Enemic") {

			RestaSalud (-0.3f);
		} else if (other.gameObject.tag == "DisparoPulpo") {

			RestaSalud (-0.2f);
		} else {

			RestaSalud (-0.1f);
		}

	}

	public void RestaSalud(float cuanto)
	{

	
		barra.fillAmount += cuanto;

		if (barra.fillAmount <= 0) {

			Morir ();

		}

	}

	void Morir() {


		numerovidas.restavida ();
		puntos.RestartPoints ();
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		if (global.vidas == 0) {

			SceneManager.LoadScene ("game_over");
			global.vidas = 3;
			numerovidas.establecevida();
			puntos.RestartPoints ();

		
		}


	}



}
