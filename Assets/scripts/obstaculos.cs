using UnityEngine;
using System.Collections;

public class obstaculos : MonoBehaviour {
	public Vector2 velocitat = new Vector2(-1,0);
	public float rango = 4;
	// Use this for initialization
	void Start () {
		GetComponent <Rigidbody2D>().velocity = velocitat;
		transform.position = new Vector3 (transform.position.x,
		                                  transform.position.y - rango * Random.value,
		                                  transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
