using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class boss : MonoBehaviour {




	public Transform puntobala;
	public GameObject bala;

	public float tiempodisparo = 3;

	public Image barra;



	void Start () {
		GetComponent<Rigidbody2D> ().velocity = new Vector2 ( GetComponent<Rigidbody2D> ().velocity.x,15);

	}

	void Update () {

		tiempodisparo -= Time.deltaTime;
		if ((int) tiempodisparo == 0) {

			Instantiate (bala, puntobala.position, puntobala.rotation);
			tiempodisparo = 3;
			tiempodisparo = Random.Range(tiempodisparo-2,tiempodisparo+2);

		}


		Vector2 posicion ;
		posicion = Camera.main.WorldToScreenPoint(transform.position);


		if (posicion.y > Screen.height  ) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 ( GetComponent<Rigidbody2D> ().velocity.x,-15);
		}

		if (posicion.y < 0) {

			GetComponent<Rigidbody2D> ().velocity = new Vector2 ( GetComponent<Rigidbody2D> ().velocity.x,15);

		}



	}



	void OnCollisionEnter2D(Collision2D other) {

		if (other.gameObject.tag == "disparojugador") {

			RestaSalud (-0.05f);
		} 

	}

	public void RestaSalud(float cuanto)
	{


		barra.fillAmount += cuanto;

		if (barra.fillAmount <= 0) {

			Destroy (this.gameObject);
			global.nivel = 1;
			SceneManager.LoadScene ("winner");

		}

	}
}
