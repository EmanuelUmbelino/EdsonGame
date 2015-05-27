using UnityEngine;
using System.Collections;

public class RunBehaviour : MonoBehaviour {
    public GameObject player;
    public GameObject enemy;
    public GameObject wall;
    public static bool jump;
    float enemyVelocity;
	// Use this for initialization
    void Start()
    {
        StartCoroutine(Spaw());
        enemyVelocity = 5;
	}
    void OnMouseDown()
    {
        enemyVelocity -= 100 / GameController.mass;
    }
	// Update is called once per frame
    void Update()
    {
        enemyVelocity += 0.01f;
        enemy.rigidbody2D.velocity = new Vector2(enemyVelocity, enemy.rigidbody2D.velocity.y);

	}
    IEnumerator Spaw()
    {
        yield return new WaitForSeconds(2);
        Instantiate(wall ,new Vector3(Random.Range(8, 11), -1.8f, -1.25f), Quaternion.identity);
        StartCoroutine(Spaw());
    }
}
