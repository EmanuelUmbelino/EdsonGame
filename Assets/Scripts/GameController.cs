using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {
    public static float mass;
    public static int Dificult;
    public GameObject timer;
    public GameObject[] MiniGames;
    public GameObject Score;
    bool minigame;
	// Use this for initialization
	void Start () {
        mass = 100;
        Dificult = 1;
        int random = Random.Range(0, MiniGames.Length);
        Instantiate(MiniGames[random]);
        minigame = true;
	}
    void FixedUpdate()
    {
        if(minigame)
            timer.GetComponent<Slider>().value -= 0.05f;
        else
            timer.GetComponent<Slider>().value += 0.1f;
    }
	// Update is called once per frame
	void Update () {
        if (timer.GetComponent<Slider>().value.Equals(0))
        {
            Destroy(GameObject.FindGameObjectWithTag("MiniGame"));
            Instantiate(Score);
            minigame = false;
        }
        if(timer.GetComponent<Slider>().value.Equals(timer.GetComponent<Slider>().maxValue))
        {
            Destroy(GameObject.FindGameObjectWithTag("Score"));
            int random = Random.Range(0, MiniGames.Length);
            Instantiate(MiniGames[random]);
            minigame = true;
            timer.GetComponent<Slider>().value -= 0.05f;
        }
	}
}
