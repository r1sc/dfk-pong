using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
    private Rigidbody2D _rigidBody;
    public float Speed;
    private AudioSource _audioSource;

    // Use this for initialization
	void Start ()
	{
	    _rigidBody = GetComponent<Rigidbody2D>();
	    _audioSource = GetComponent<AudioSource>();
	    ResetBall();
	}

    private void ResetBall()
    {
        transform.position = Vector3.zero;
        _rigidBody.velocity = new Vector2(Mathf.Sign(Random.value - 0.5f), Mathf.Sign(Random.value - 0.5f)).normalized*Speed;
    }

    // Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Enter trigger");
        ResetBall();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        _audioSource.Play();
    }
}
