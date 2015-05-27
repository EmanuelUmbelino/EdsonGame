using UnityEngine;
using System.Collections;

public class JumpBehavior : MonoBehaviour {
	public GameObject player;
	public float forceJump;
	public GameObject aipim;
	bool instantiate = false;
	// Use this for initialization
	void Start () {
		instantiate = false;
		forceJump = 10000;
	}
	void OnMouseDown()
	{
		//if(jump.Equals(false) ){player.rigidbody2D.AddForce(new Vector2 (0, forceJump));jump = true; }

	}
	// Update is called once per frame
	void Update () {
		if (!instantiate)
            StartCoroutine (Spaw());
	}
	IEnumerator Spaw() {
		instantiate = true;	yield return new WaitForSeconds(2);
		Instantiate(aipim, new Vector2 (Random.Range (8, 11), -1.8f), Quaternion.identity);
		instantiate = false;
	}

	
}
