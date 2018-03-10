using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCamera : MonoBehaviour {

    //Variables
    public Transform Ball;
    public float smooth = 0.3f;

    public float height;

    private Vector3 velocity = Vector3.zero;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 pos = new Vector3();
        pos.x = Ball.position.x;
        pos.z = Ball.position.z;
        pos.y = Ball.position.y + height;
        transform.position = Vector3.SmoothDamp(transform.position, pos, ref velocity, smooth);

	}
}
