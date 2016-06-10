using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OutOfBounds : MonoBehaviour
{
    public int PlayerScore;
    public Text ScoreText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerScore++;
        ScoreText.text = PlayerScore.ToString();
    }
}
