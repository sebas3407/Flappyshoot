 using UnityEngine;
using System.Collections;

public class pulpo : MonoBehaviour {

	public Transform player;

	public Transform puntobala;
	public GameObject bala;

	public float tiempodisparo = 3;

	void Start () {

	}
	
	void Update () {

		tiempodisparo -= Time.deltaTime;
		if ((int) tiempodisparo == 0) {

			Instantiate (bala, puntobala.position, puntobala.rotation);
			tiempodisparo = 3;
			tiempodisparo = Random.Range(tiempodisparo-2,tiempodisparo+2);

		}



		if (this.transform.position.x < player.position.x) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (15, GetComponent<Rigidbody2D> ().velocity.y);
		}
		if (this.transform.position.x > player.position.x) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-15, GetComponent<Rigidbody2D> ().velocity.y);
		}
		if (this.transform.position.y < player.position.y) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x,15);
		}
		if (this.transform.position.y > player.position.y) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 ( GetComponent<Rigidbody2D> ().velocity.x,-15);
		}

	}
}
