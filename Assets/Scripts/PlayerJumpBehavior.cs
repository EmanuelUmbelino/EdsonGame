using UnityEngine;
using System.Collections;

public class PlayerJumpBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}
	void OnCollisionStay2D(Collision2D col) {

        if (col.gameObject.tag.Equals("chao")) RunBehaviour.jump = false;
	}
	void OnCollisionExit2D(Collision2D col) {
		RunBehaviour.jump = true;
	}
}
