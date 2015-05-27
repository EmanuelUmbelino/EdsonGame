using UnityEngine;
using System.Collections;

public class PlayerFoodController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Good"))
            Destroy(col.gameObject); 
        if (col.gameObject.tag.Equals("Bad"))
            Destroy(col.gameObject);
    }
	// Update is called once per frame
	void Update () {
        rigidbody2D.velocity = new Vector2(10 * Input.acceleration.x, 0);
	}
}
