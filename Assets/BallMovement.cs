using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKey(KeyCode.RightArrow)){
			rigidbody2D.AddForce(Vector3.right*10.0f);
		}
		else if(Input.GetKey(KeyCode.LeftArrow)){
			rigidbody2D.AddForce(Vector3.left*10.0f);
		}
		else if(Input.GetKey(KeyCode.UpArrow))
		{
			rigidbody2D.AddForce(Vector3.up*10.0f);
		}
	}

	void OnCollisionEnter2D(Collision2D other){
		if(other.transform.CompareTag("NoCollide"))
			other.collider.enabled=false;
	}
}
