using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {
    public GameObject myPrefab;

    public float delayDuration = 1.0f;

    private float timeOfShot = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Jump"))
        {
            if (Time.time > timeOfShot + delayDuration)
            {
                Instantiate(myPrefab, transform.position, transform.rotation);

                timeOfShot = Time.time;
            }
        }
	}
}
