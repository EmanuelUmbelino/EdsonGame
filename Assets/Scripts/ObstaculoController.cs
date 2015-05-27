using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    GameObject instancia;
	// Use this for initialization
	void Start () {
        instancia = GameObject.FindGameObjectWithTag("MiniGame");
        transform.SetParent(instancia.transform);
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody2D.velocity = new Vector2(-1, rigidbody2D.velocity.y);
		if (transform.position.x < -8)
		    Destroy (gameObject);
	}
}
