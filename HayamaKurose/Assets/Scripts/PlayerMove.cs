﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	public float moveMultiplier = 0.2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey(KeyCode.W))
		{
			transform.position = transform.position + (transform.forward * moveMultiplier);
		}

		if (Input.GetKey(KeyCode.S))
		{
			transform.position = transform.position + (transform.forward * -moveMultiplier);
		}
		
		if (Input.GetKey(KeyCode.A))
		{
			transform.position = transform.position + (transform.right * -moveMultiplier);
		}
		
		if (Input.GetKey(KeyCode.D))
		{
			transform.position = transform.position + (transform.right * moveMultiplier);
		}

		if (Input.GetKey(KeyCode.Q))
		{
			transform.Rotate (new Vector3(0, -1, 0));
		}
		
		if (Input.GetKey(KeyCode.E))
		{
			transform.Rotate (new Vector3(0, -1, 0));
		}
	
	}
}
