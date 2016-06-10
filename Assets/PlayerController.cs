using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float Speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	    var vertical = Input.GetAxis("Vertical");
	    transform.position += Vector3.up*vertical*Speed*Time.deltaTime;
	}
}
