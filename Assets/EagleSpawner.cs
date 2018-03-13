using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EagleSpawner : MonoBehaviour {

    public float gap = 20;
    public float followers = 2;
    public GameObject prefab;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Awake()
    {
        // spawn first eagle at spawner position
        GameObject eagle = GameObject.Instantiate<GameObject>(prefab);
        Vector3 eaglePos = transform.position;
        eagle.transform.position = eaglePos;

        // make variable to handle growing gap between ships
        float spaceBetween = gap;

        // spawn eagles in formation
        for (int i = 0; i < followers; i++)
        {
            GameObject rightEagle = GameObject.Instantiate<GameObject>(prefab);
            Vector3 rightPos = transform.position;
            rightPos.x = eagle.transform.position.x + spaceBetween;
            rightPos.y = eaglePos.y;
            rightPos.z = eagle.transform.position.z - spaceBetween;
            rightEagle.transform.position = rightPos;

            GameObject leftEagle = GameObject.Instantiate<GameObject>(prefab);
            Vector3 leftPos = transform.position;
            leftPos.x = eagle.transform.position.x - spaceBetween;
            leftPos.y = eaglePos.y;
            leftPos.z = eagle.transform.position.z - spaceBetween;
            leftEagle.transform.position = leftPos;

            spaceBetween += gap;
        }
    }
}
