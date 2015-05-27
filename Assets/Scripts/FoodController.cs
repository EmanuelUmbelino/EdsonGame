using UnityEngine;
using System.Collections;

public class FoodController : MonoBehaviour {

    GameObject instancia;
	// Use this for initialization
    void Start()
    {
        instancia = GameObject.FindGameObjectWithTag("MiniGame");
        transform.SetParent(instancia.transform);
	
	}
	
	// Update is called once per frame
    void Update()
    {
        rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, -2 * GameController.Dificult);
        if (transform.position.y < -8)
            Destroy(gameObject);
	
	}
}
