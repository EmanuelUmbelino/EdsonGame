using UnityEngine;
using System.Collections;

public class FoodBehaviour : MonoBehaviour {
    public Canvas Mycanvas;
    public GameObject[] Foods;
	// Use this for initialization
	void Start () {
        Mycanvas.worldCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        StartCoroutine(Spaw());
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
    IEnumerator Spaw()
    {
        int comida = Random.Range(0, Foods.Length);
        Instantiate(Foods[comida], new Vector2(Random.Range(-5, 5), 6), Quaternion.identity);
        yield return new WaitForSeconds(2);
        StartCoroutine(Spaw());
    }
}
