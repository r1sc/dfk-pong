using UnityEngine;
using System.Collections;

public class AIController : MonoBehaviour
{
    public float Speed;
    public Ball Ball;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Ball.transform.position.x > 0)
	    {
	        var pos = transform.position;
	        if (Ball.transform.position.y < pos.y)
	            pos.y -= Speed * Time.deltaTime;
            else if(Ball.transform.position.y > pos.y)
                pos.y += Speed * Time.deltaTime;
	        transform.position = pos;
	    }
	}
}
