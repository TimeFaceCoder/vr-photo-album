﻿using UnityEngine;
using System.Collections;

public class MovingObject : MonoBehaviour {

	public float angle =0;
	public float angle2 = 0;
	public float speed=(2*Mathf.PI)/5; //2*PI in degress is 360, so you get 5 seconds to complete a circle
	public float radius=17;

	public float x, y, z;
	// Use this for initialization
	void Start () {		
	}

	// Update is called once per frame
	void Update () {
		angle += speed*Time.deltaTime; //if you want to switch direction, use -= instead of +=
		x = Mathf.Cos(angle2)*Mathf.Cos(angle)*radius;
		//z = Mathf.Sin(angle2)*radius;
		z = Mathf.Sin(angle)*radius;
		y = radius * Mathf.Sin(angle2)*Mathf.Cos(angle);
		transform.position = new Vector3(x,y,z);
	}
}
