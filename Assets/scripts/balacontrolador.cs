using UnityEngine;
using System.Collections;

public class balacontrolador : MonoBehaviour {

	public float speed;

	void Start () {

	
	}
	
	void Update () {
	
	
		GetComponent<Rigidbody2D>().velocity = new Vector2 (speed, GetComponent<Rigidbody2D>().velocity .y);

		Destroy (this.gameObject,4);

	}

	void OnCollisionEnter2D(Collision2D other)
	{
		Destroy (this.gameObject);
		if (other.gameObject.tag == "Enemic") {

			Destroy (other.gameObject);

			puntos.AddPoints (100);
	


		}

	}
}
