using UnityEngine;
using System.Collections;

public class balapulpo : MonoBehaviour {

	public float velocidadbala;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (-velocidadbala,GetComponent<Rigidbody2D> ().velocity.y);
		Destroy (this.gameObject,4);
	}


	void OnCollisionEnter2D(Collision2D other)
	{
		Destroy (this.gameObject);
	

	}
}
