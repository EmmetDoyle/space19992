using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boid : MonoBehaviour {


    public float mass = 1;
    public float maximumSpeed = 10;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /*
    public Vector3 SeekForce(Vector3 target)
    {
        Vector3 desired = target - transform.position;
        desired *= maximumSpeed;
        return desired;
    }

    public Vector3 ArriveForce(Vector3 target)
    {

    }
    */
}
